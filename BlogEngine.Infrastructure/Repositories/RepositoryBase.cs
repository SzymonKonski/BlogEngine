using BlogEngine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BlogEngine.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlogEngine.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        protected Context Context { get; set; }

        public RepositoryBase(Context repositoryContext)
        {
            this.Context = repositoryContext;
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>().AsNoTracking();
        }

        public async Task Create(T entity)
        {
           await Context.Set<T>().AddAsync(entity);
           await Context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            this.Context.Set<T>().Update(entity);
            await Context.SaveChangesAsync();

        }

        public async Task Delete(T entity)
        {
            this.Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }

        public T GetById(int id)
        { 
            T item = this.Context.Set<T>().FirstOrDefault(s => s.Id == id);
            return item;
        }

    }
}
