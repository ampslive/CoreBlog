using CoreBlog.Contracts;
using CoreBlog.Models;
using CoreBlog.Utilities;
using System;
using Xunit;

namespace CoreBlog.Test
{
    public class UnitTest1
    {
        [Fact]
        public void SaveToMSSQLTest()
        {
            //var db = new AppContext();
            //IPersistenceBehavior<Post> saveToMSSQL = new MSSQLDatabase<Post>(db);

            //Post testPost = new Post(saveToMSSQL);
            //var content = new TextContent();
            //content.PostText = "Hey this is my content";

            //testPost.Content = content;
            //testPost.Title = "First Post";

            //testPost.SavePost(testPost);
            //obj.SaveToDb(testPost);

            //Assert.Contains("First Post", testPost.Title);
        }

        [Fact]
        public void SaveToJsonTest()
        {
            IPersistenceBehavior<Post> saveToJson = new JSONDatabase<Post>();

            Post testPost = new Post(saveToJson);
            var content = new TextContent();
            content.PostText = "Hey this is my content";

            Assert.Contains("Hey this is my content", content.PostText);
        }
    }
}
