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
    public class CustomerRepository : IRepository<Customer>
    {
        public RezervacijeModel Context { get; set; }

        public CustomerRepository()
        {
            Context = new RezervacijeModel();
        }

        public async Task<List<Customer>> GetList()
        {
            return await Context.Customer.ToListAsync();
        }

        public async Task<Customer> Find(Guid Id)
        {
            return await Ext.FindAsync(Context.Customer, Id);
        }

        public async Task Insert(Customer data)
        {
            await Task.Run(() =>
            {
                Context.Customer.Add(data);
            });
        }

        public async Task Update(Customer data)
        {
            await Task.Run(() =>
            {
                Context.Entry(data).State = EntityState.Modified;
            });
        }

        public async Task Delete(Customer data)
        {
            await Task.Run(() =>
            {
                Context.Customer.Remove(data);
            });
        }

        public async Task<List<Customer>> Where(Expression<Func<Customer, bool>> predicate)
        {
            return await Context.Customer.Where(predicate).ToListAsync();
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