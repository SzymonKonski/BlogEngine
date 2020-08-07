using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEngine.Application.ViewModels
{
    public class PostListViewModel
    {
        public List<PostViewModel> Posts { get; set; }
        public int Count { get; set; }
    }
}
