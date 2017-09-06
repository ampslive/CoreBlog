using CoreBlog.Constants;
using CoreBlog.Contracts;
using System;
using System.Collections.Generic;

namespace CoreBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IPostContent Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        //public List<> Author { get; set; }
        public PostStatus Status { get; set; }
        public bool IsActive { get; set; }
    }
}