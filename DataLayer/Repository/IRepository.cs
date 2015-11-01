using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity 
    {
        Task<List<TEntity>> GetList();
        Task<TEntity> Find(Guid Id);
        Task Insert(TEntity data);
        Task Update(TEntity data);
        Task Delete(TEntity data);
        Task<List<TEntity>> Where(Expression<Func<TEntity, Boolean>> predicate);
    }

}
