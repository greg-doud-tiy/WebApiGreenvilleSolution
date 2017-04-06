using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiGreenville.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie>() {
                new Movie() { Name = "Caddy Shack", Description = "More funny today" },
                new Movie() { Name = "Animal House", Description = "Just as funny today" },
                new Movie() { Name = "Gone with the Wind", Description = "A classic" },
                new Movie() { Name = "Lord of the Rings", Description = "My favorite" },
                new Movie() { Name = "Underworld", Description = "My wife hates this one" }
            };
            return Json(movies, JsonRequestBehavior.AllowGet);
        }
    }
    public class Movie
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}