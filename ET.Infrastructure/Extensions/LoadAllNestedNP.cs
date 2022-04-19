using System;
using System.Linq;
using ET.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace ET.Infrastructure.Extensions
{
    public class LoadAllNestedNP<T> where T:class 
    {
        private readonly ETContext _context;

        public LoadAllNestedNP(ETContext context)
        {
            _context = context;
        }

        public virtual IQueryable<T> Query(bool eager = false)
        {
            var query = _context.Set<T>().AsQueryable();
            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(T)).GetNavigations())
                    query = query.Include(property.Name);
            }
            return query;
        }

        public virtual T Get(Guid itemId, bool eager = false)
        {
            return Query(eager).SingleOrDefault(i => i.GetType().GUID == itemId);
        }
    }
}
