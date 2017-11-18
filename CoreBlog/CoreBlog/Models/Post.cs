using CoreBlog.Constants;
using CoreBlog.Contracts;
using CoreBlog.Utilities;
using System;

namespace CoreBlog.Models
{
    public class Post : IPersistenceBehavior<Post>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IPostContent Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        //public List<> Author { get; set; }
        public PostStatus Status { get; set; }
        public string Permalink { get; set; }
        public bool IsActive { get; set; }

        private IPersistenceBehavior<Post> persistBehavior { get; set; }

        public Post(IPersistenceBehavior<Post> pb)
        {
            this.persistBehavior = pb;
        }

        public void Add(Post obj)
        {
            persistBehavior.Add(obj);
        }

        public void Update(Post obj)
        {
            throw new NotImplementedException();
        }
    }
}