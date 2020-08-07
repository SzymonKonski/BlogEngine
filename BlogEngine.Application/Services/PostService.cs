using AutoMapper;
using AutoMapper.QueryableExtensions;
using BlogEngine.Application.Interfaces;
using BlogEngine.Application.ViewModels;
using BlogEngine.Core.Interfaces;
using BlogEngine.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlogEngine.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepo;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepo, IMapper mapper)
        {
            _postRepo = postRepo;
            _mapper = mapper;
        }

        public async Task Delete(int postId)
        {
            var item =  _postRepo.GetById(postId);
            await _postRepo.Delete(item);
        }

        public async Task Create(PostViewModel postVm)
        {
            var item = _mapper.Map<Post>(postVm);
            await _postRepo.Create(item);
        }
        public async Task Update(PostViewModel postVm)
        {
            var item = _mapper.Map<Post>(postVm);
            await _postRepo.Update(item);
        }

        public async Task<PostViewModel> GetById(int postId)
        {
            Post post =  _postRepo.GetById(postId);
            PostViewModel postViewModel = _mapper.Map<PostViewModel>(post);
            return postViewModel;
        }

        public async Task<PostListViewModel> GetAll()
        {
            var posts = await _postRepo.GetAll()
                                       .ProjectTo<PostViewModel>(_mapper.ConfigurationProvider)
                                       .ToListAsync();
            return new PostListViewModel()
            {
                Posts = posts,
                Count = posts.Count
            };
        
         }
    }
}
