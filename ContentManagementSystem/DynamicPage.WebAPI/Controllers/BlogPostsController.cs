using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicPage.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DynamicPage.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : Controller
    {
        private readonly BlogPostsDBContext _context;

        public BlogPostsController()
        {
            _context = new BlogPostsDBContext();
        }

        // GET api/blogposts
        [HttpGet]
        public List<BlogPosts> Get()
        {
            return _context.BlogPosts.ToList();
        }

        // GET api/blogposts/5
        [HttpGet("{id}")]
        public BlogPosts Get(int id)
        {
            return _context.BlogPosts.Find(id);
        }

        // POST api/blogposts
        [HttpPost]
        public IActionResult Post([FromBody]BlogPosts blogPosts)
        {
            _context.BlogPosts.Add(blogPosts);
            _context.SaveChanges();
            return new ObjectResult("Blog added successfully.");
        }

        // PUT api/blogposts/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]BlogPosts blogPosts)
        {
            _context.Entry<BlogPosts>(blogPosts).State = EntityState.Modified;
            _context.SaveChanges();
            return new ObjectResult("Blog Modified successfully.");
        }

        // DELETE api/blogposts/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.BlogPosts.Remove(_context.BlogPosts.Find(id));
            _context.SaveChanges();
            return new ObjectResult("Blog Deleted successfully.");
        }
    }
}
