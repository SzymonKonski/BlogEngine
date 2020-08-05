using System;
using System.Collections.Generic;
using System.Text;
using BlogEngine.Application.ViewModels;

namespace BlogEngine.Application.Interfaces
{
    public interface IPostService
    {
        void Create(PostViewModel postVm);
        void Update(PostViewModel postVm);
        void Delete(int postId);
        PostViewModel GetById(int postId);
    }
}
