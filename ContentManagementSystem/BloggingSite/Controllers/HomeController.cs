using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BloggingSite.Models;
using Newtonsoft.Json;

namespace BloggingSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var blogPostsRestClient = new BlogPostsRestClient();
            var responseData = blogPostsRestClient.FindAll().Result;
            ViewBag.blogs = JsonConvert.DeserializeObject<List<BlogPostsModel>>(responseData);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
