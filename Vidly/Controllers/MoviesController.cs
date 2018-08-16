﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [Route("Movies")]
        public ViewResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"}
            };

            var indexMovieViewModel = new IndexMovieViewModel()
            {
                Movies = movies
            };
            return View(indexMovieViewModel);
        }
    }
}