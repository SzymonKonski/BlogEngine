using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.Core.Models;

namespace BlogEngine.Core.Interfaces
{
    public interface IRepositoryBase<T>  where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
