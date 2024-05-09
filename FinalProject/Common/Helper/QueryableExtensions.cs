using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.Helper
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Page<T>(this IQueryable<T> query, int page, int pageSize)
        {
            return query.Skip((page - 1) * pageSize).Take(pageSize);
        }

        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Func<T, bool> predicate)
        {
            return condition ? query.Where(predicate).AsQueryable() : query;
        }

        public static IQueryable<T> OrderByIf<T>(this IQueryable<T> query, bool condition, Func<T, object> keySelector)
        {
            return condition ? query.OrderBy(keySelector).AsQueryable() : query;
        }

        public static string ToSql<T>(this IQueryable<T> query)
        {
            var sql = query.ToString();
            return sql;
        }
    }
}
