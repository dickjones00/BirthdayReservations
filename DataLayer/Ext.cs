using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class Ext
    {
        public static Task<List<T>> ToListAsync<T>(this IQueryable<T> Query)
        {
            return Task.Run(() => { return Query.ToList(); });
        }

        public static Task<T> FindAsync<T>(this DbSet<T> Query, Guid Id) where T : class
        {
            return Task.Run(() => { return Query.Find(Id); });
        }

        public static Task<T> FirstOrDefaultAsync<T>(this IQueryable<T> Query)
        {
            return Task.Run(() => { return Query.FirstOrDefault(); });
        }
    }
}
