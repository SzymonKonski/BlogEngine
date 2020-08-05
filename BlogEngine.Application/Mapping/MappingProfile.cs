using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AutoMapper;
using BlogEngine.Application.ViewModels;
using BlogEngine.Core.Models;

namespace BlogEngine.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostViewModel, Post>();
        }
    }


    
}
