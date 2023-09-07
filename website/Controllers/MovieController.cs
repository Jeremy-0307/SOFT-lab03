using website.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace website.Controllers
{
  public class MovieController : Controller
  {
    public IActionResult Index()
    {
      var movies = GetListOfMovies();
      ViewBag.MainTitle = "List of my favorite films";
      return View(movies);
    }
    private List<MovieModel> GetListOfMovies()
    {
      List<MovieModel> movies = new List<MovieModel>();
      movies.Add(new MovieModel
      {
        Id = 1,
        Name = "Everything Everywhere All at Once",
        Genre = "Family/Sci-fiction",
        ReleaseDate = new DateTime(2022, 3, 11)
      });
      movies.Add(new MovieModel
      {
        Id = 1,
        Name = "A silent voice",
        Genre = "Animated/Romance",
        ReleaseDate = new DateTime(2016, 9, 17)
      });
      movies.Add(new MovieModel
      {
        Id = 1,
        Name = "Scott Pilgrim vs The World",
        Genre = "Comedy/Action",
        ReleaseDate = new DateTime(2010, 8, 13)
      });

      return movies;
    }
  }
}
