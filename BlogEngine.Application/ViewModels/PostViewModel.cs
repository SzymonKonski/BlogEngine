using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BlogEngine.Core.Models;

namespace BlogEngine.Application.ViewModels
{
    public class PostViewModel 
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Author { get; set; }
    }
}
