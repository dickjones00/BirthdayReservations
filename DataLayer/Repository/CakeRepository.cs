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
    public class CakeRepository : IRepository<Cake>
    {
        public RezervacijeModel Context { get; set; }

        public CakeRepository()
        {
            Context = new RezervacijeModel();            
        }

        public async Task<List<Cake>> GetList()
        {
            return await Context.Cake.ToListAsync();            
        }

        public async Task<Cake> Find(Guid Id)
        {
            return await Ext.FindAsync(Context.Cake, Id);
        }

        public async Task Insert(Cake data)
        {
            await Task.Run(() =>
                {
                    Context.Cake.Add(data);            
                });            
        }

        public async Task Update(Cake data)
        {            
            await Task.Run(() =>
            {
                Context.Entry(data).State = EntityState.Modified;
            });  
        }

        public async Task Delete(Cake data)
        {
            await Task.Run(() =>
            {
                Context.Cake.Remove(data);
            });  
        }

        public async Task<List<Cake>> Where(Expression<Func<Cake, bool>> predicate)
        {
            return await Context.Cake.Where(predicate).ToListAsync();
        }

        public void Dispose()
        {
            if(Context != null)
            {
                Context.Dispose();
                Context = null;
            }
        }        
    }
}
