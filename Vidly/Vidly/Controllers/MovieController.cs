using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "The Godfather"
            };
            
            return View(movie);
        }
    }
}