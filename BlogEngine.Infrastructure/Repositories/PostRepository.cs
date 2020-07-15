using System;
using System.Collections.Generic;
using System.Text;
using BlogEngine.Core.Interfaces;
using BlogEngine.Core.Models;

namespace BlogEngine.Infrastructure.Repositories
{
    public class PostRepository :  RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(Context repositoryContext) : base(repositoryContext)
        {
        }
    }
}
