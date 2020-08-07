using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.Application.Services;
using BlogEngine.Application.ViewModels;

namespace BlogEngine.Application.Interfaces
{
    public interface IPostService
    {
        Task<PostListViewModel> GetAll();
        Task Create(PostViewModel postVm);
        Task Update(PostViewModel postVm);
        Task Delete(int postId);
        Task<PostViewModel> GetById(int postId);
    }
}
