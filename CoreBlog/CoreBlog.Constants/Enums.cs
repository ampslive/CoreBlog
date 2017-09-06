using System;

namespace CoreBlog.Constants
{
    public enum PostStatus
    {
        Draft = 0,
        Publish = 1,
        Archive = 2
    }

    public enum PostType
    {
        Text = 0,
        Media = 1,
        Quote = 2,
        Embed = 3
    }
}
