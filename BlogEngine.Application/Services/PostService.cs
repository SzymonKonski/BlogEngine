using AutoMapper;
using BlogEngine.Application.Interfaces;
using BlogEngine.Application.ViewModels;
using BlogEngine.Core.Interfaces;
using BlogEngine.Core.Models;

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

        public void Delete(int postId)
        {
            var item = _postRepo.GetById(postId);
            _postRepo.Delete(item);
            _postRepo.Save();
        }

        public void Create(PostViewModel postVm)
        {
            var item = _mapper.Map<Post>(postVm);
            _postRepo.Create(item);
            _postRepo.Save(); 
        }
        public void Update(PostViewModel postVm)
        {
            var item = _mapper.Map<Post>(postVm);
            _postRepo.Update(item);
            _postRepo.Save();
        }

        public PostViewModel GetById(int postId)
        {
            Post post = _postRepo.GetById(postId);
            PostViewModel postViewModel = _mapper.Map<PostViewModel>(post);
            return postViewModel;
        }
    }
}
