using DataLayer.Context;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace DataLayer.Repository
{
    public class OrderRepository : IRepository<Order>
    {
        public RezervacijeModel Context { get; set; }

        public OrderRepository()
        {
            Context = new RezervacijeModel();
        }

        public async Task<List<Order>> GetList()
        {
            return await Context.Order.ToListAsync();
        }

        public async Task<Order> Find(Guid Id)
        {
            return await Ext.FindAsync(Context.Order, Id);
        }

        public async Task Insert(Order data)
        {
            await Task.Run(() =>
            {
                Context.Order.Add(data);
            });
        }

        public async Task Update(Order data)
        {
            await Task.Run(() =>
            {
                Context.Entry(data).State = EntityState.Modified;
            });
        }

        public async Task Delete(Order data)
        {
            await Task.Run(() =>
            {
                Context.Order.Remove(data);
            });
        }

        public async Task<List<Order>> Where(Expression<Func<Order, bool>> predicate)
        {
            return await Context.Order.Where(predicate).ToListAsync();
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
                Context = null;
            }
        }

    }
}