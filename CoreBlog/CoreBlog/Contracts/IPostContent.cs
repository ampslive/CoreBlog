using CoreBlog.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Contracts
{
    public interface IPostContent
    {
        //PostType postType;
        void SavePost();
        void EditPost();
        void DeletePost();
        //public DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }
        //public bool IsActive { get; set; }
    }

    public class TextContent : IPostContent
    {
        public string PostText { get; set; }

        public void DeletePost()
        {
            throw new NotImplementedException();
        }

        public void EditPost()
        {
            throw new NotImplementedException();
        }

        public void SavePost()
        {
            throw new NotImplementedException();
        }
    }

    public class QuoteContent : IPostContent
    {
        public string QuoteText { get; set; }

        public void DeletePost()
        {
            throw new NotImplementedException();
        }

        public void EditPost()
        {
            throw new NotImplementedException();
        }

        public void SavePost()
        {
            throw new NotImplementedException();
        }

    }
}
