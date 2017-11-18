using CoreBlog.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class BlogSeries : IPersistenceBehavior<BlogSeries>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Post> Posts { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }

        private IPersistenceBehavior<BlogSeries> persistBehavior { get; set; }

        public BlogSeries(IPersistenceBehavior<BlogSeries> pb)
        {
            this.persistBehavior = pb;
        }

        public void Save(BlogSeries obj)
        {
            persistBehavior.Add(obj);
        }

        public void Add(BlogSeries obj)
        {
            throw new NotImplementedException();
        }

        public void Update(BlogSeries obj)
        {
            throw new NotImplementedException();
        }
    }
}
