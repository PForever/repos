using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

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
                        .TryAdd(s => s.City == "wqe", false));
                foreach (var some in res)
                {
                    Console.WriteLine($"{some.Id}, {some.City}");
                }
            }

            //IQueryable<Some> query = somes.AsQueryable();
            //var res = query.Where(Filter.Create<Some>(s => s.Prop1 == q1, q1.HasValue)
            //    .TryAdd(s => s.Prop2 == q2, q2.HasValue)
            //    .TryAdd(s => s.Prop3 == q3, q3.HasValue));


            Console.ReadKey();

            //var y = default(LambdaExpression)
            //    .TryAdd<Predicate<int?>>(q => q == 0, q1.HasValue)
            //    .TryAdd<Predicate<int?>>(q => q == 1, q2.HasValue)
            //    .TryAdd<Predicate<int?>>(q => q == 2, q3.HasValue);
            //IQueryable<int?> query;
            //query.Where(default(LambdaExpression)
            //    .TryAdd<Predicate<int?>>(q => q == 0, q1.HasValue)
            //    .TryAdd<Predicate<int?>>(q => q == 1, q2.HasValue)
            //    .TryAdd<Predicate<int?>>(q => q == 2, q3.HasValue));
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
    }
}
