using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BlogEngine.Core.Models;

namespace BlogEngine.Core.Interfaces
{
    public interface IRepositoryBase<T>  where T : BaseEntity
    {
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
