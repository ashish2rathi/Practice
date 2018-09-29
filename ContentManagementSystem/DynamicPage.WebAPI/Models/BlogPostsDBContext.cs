using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DynamicPage.WebAPI.Models
{
    public class BlogPostsDBContext : DbContext
    {
        public DbSet<BlogPosts> BlogPosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=KLIN0043\SQLEXPRESS;Initial Catalog=ContentManagementSystem;Integrated Security=True;");
        }

    }
}
