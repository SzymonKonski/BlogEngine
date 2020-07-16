using System;
using System.Collections.Generic;
using System.Text;
using BlogEngine.Application.Interfaces;
using BlogEngine.Core.Interfaces;

namespace BlogEngine.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository postRepo;

    }
}
