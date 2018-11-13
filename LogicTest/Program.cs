using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace LogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var somes = new Some[]
            {
                new Some(0, 1, 2),
                new Some(0, 1, 2),
                new Some(0, 1, 2)
            };

            var qwe = Filter.Add<Some>(l => l.Prop1 == 0, l => l.Prop2 == 1);
            var qweC = qwe.Compile();
            Console.WriteLine(qweC(somes[0]));
            Console.ReadKey();


            int? q1 = 0;
            int? q2 = 1;
            int? q3 = 2;


            var l1 = Filter.Add<Some>(s => s.Prop1 == 1, s => s.Prop2 == 1);
            var l2 = Filter.Add<Some>(s => s.Prop1 == 1, s => s.Prop2 == 1);
            var l12 = Filter.Add(l1, l2);
            Console.WriteLine(l12.Compile()(somes[1]));

            using (var context = new EmployerPartnersEntities())
            {
                var res = context.OrgAddresses.Where(Filter
                        .Create<OrgAddress>(s => !s.IsDefault, false)
                        .TryAdd(s => s.Id > 3, true)
                        .TryAdd(s => s.Id < 8, true)
                        .TryAdd(s => s.City == "wqe", false))
                    .Select(Filter.CreateNewStatement<OrgAddress>("Id"));
                foreach (var some in res)
                {
                    Console.WriteLine($"{some.Id}, {some.City}");
                }
            }

            Console.ReadKey();

        }
    }

    class Some
    {
        public int? Prop1 {get; set;}
        public int? Prop2 {get; set;}
        public int? Prop3 { get; set; }

        public Some(int? prop1, int? prop2, int? prop3)
        {
            Prop1 = prop1;
            Prop2 = prop2;
            Prop3 = prop3;
        }

        public override string ToString()
        {
            return $"Prop1 = {Prop1}, Prop2 = {Prop2}, Prop3 = {Prop3}";
        }
    }
    public static class Filter
    {

        public static Expression<Func<T, bool>> Create<T>(this Expression<Func<T, bool>> mainExpression, bool predicateResult)
        {
            return predicateResult ? mainExpression : null;
        }
        public static Expression<Func<T, bool>> TryAdd<T>(this Expression<Func<T, bool>> mainExpression, Expression<Func<T, bool>> addbleExpression, bool predicateResult)
        {
            if (!predicateResult) return mainExpression;
            if (mainExpression == null) return addbleExpression;
            return AndAlso(mainExpression, addbleExpression);
        }
        public static Expression<Func<T, bool>> Add<T>(this Expression<Func<T, bool>> mainExpression, Expression<Func<T, bool>> addbleExpression)
        {
            return AndAlso(mainExpression, addbleExpression);
        }
        //public static Expression<Func<T, dynamic>> Add<T>(this Expression<Func<T, dynamic>> mainExpression, Expression<Func<T, dynamic>> addbleExpression)
        //{


        //}

        class ParameterVisitor : ExpressionVisitor
        {
            private readonly ReadOnlyCollection<ParameterExpression> from, to;
            public ParameterVisitor(
                ReadOnlyCollection<ParameterExpression> from,
                ReadOnlyCollection<ParameterExpression> to)
            {
                if (from == null) throw new ArgumentNullException("from");
                if (to == null) throw new ArgumentNullException("to");
                if (from.Count != to.Count) throw new InvalidOperationException(
                    "Parameter lengths must match");
                this.from = from;
                this.to = to;
            }
            protected override Expression VisitParameter(ParameterExpression node)
            {
                for (int i = 0; i < from.Count; i++)
                {
                    if (node == from[i]) return to[i];
                }
                return node;
            }
        }
        public static Expression<Func<T, bool>> AndAlso<T>(
            Expression<Func<T, bool>> x, Expression<Func<T, bool>> y)
        {
            var newY = new ParameterVisitor(y.Parameters, x.Parameters)
                .VisitAndConvert(y.Body, "AndAlso");
            return Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(x.Body, newY),
                x.Parameters);
        }

        public static Expression<Func<T, T>> CreateNewStatement<T>(string fields)
        {
            // input parameter "o"
            var xParameter = Expression.Parameter(typeof(T), "o");

            // new statement "new Data()"
            var xNew = Expression.New(typeof(T));

            // create initializers
            var bindings = fields.Split(',').Select(o => o.Trim())
                .Select(o => {

                        // property "Field1"
                        var mi = typeof(T).GetProperty(o);

                        // original value "o.Field1"
                        var xOriginal = Expression.Property(xParameter, mi);

                        // set value "Field1 = o.Field1"
                        return Expression.Bind(mi, xOriginal);
                    }
                );

            // initialization "new Data { Field1 = o.Field1, Field2 = o.Field2 }"
            var xInit = Expression.MemberInit(xNew, bindings);

            // expression "o => new Data { Field1 = o.Field1, Field2 = o.Field2 }"
            return Expression.Lambda<Func<T, T>>(xInit, xParameter);
        }
    }
}
