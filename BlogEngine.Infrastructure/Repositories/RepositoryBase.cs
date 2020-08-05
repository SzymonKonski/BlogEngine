using BlogEngine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BlogEngine.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEngine.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        protected Context RepositoryContext { get; set; }

        public RepositoryBase(Context repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);           
        }

        public T GetById(int id)
        { 
            T item = this.RepositoryContext.Set<T>().FirstOrDefault(s => s.Id == id);
            return item;
        }

        public void Save()
        {
            this.RepositoryContext.SaveChanges();
        }
    }
}
