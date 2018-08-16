using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private MyDbContext _context = new MyDbContext();

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        [Route("Movies")]
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            var indexMovieViewModel = new IndexMovieViewModel()
            {
                Movies = movies
            };
            return View(indexMovieViewModel);
        }
    }
}