using CoreBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoreBlog.SQLDBProvider
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        private string _connectionString = @"";

        public DbSet<BlogSeries> Blogs;
        public DbSet<Post> Posts;

        public BloggingContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlite("Data Source=blogging.db");
        //    optionsBuilder.UseSqlServer(_connectionString);
        //}
        public BloggingContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
            optionsBuilder.UseSqlServer(_connectionString);

            return new BloggingContext(optionsBuilder.Options);
        }
    }

    //public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingContext>
    //{
    //    private string _connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    //    public BloggingContext CreateDbContext(string[] args)
    //    {

    //        var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
    //        optionsBuilder.UseSqlServer(_connectionString);

    //        return new BloggingContext(optionsBuilder.Options);
    //    }
    //}

}
