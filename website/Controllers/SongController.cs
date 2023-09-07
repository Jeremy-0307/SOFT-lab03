using website.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace website.Controllers
{
  public class SongController : Controller
  {
    public IActionResult Index()
    {
      var songs = GetListOfSongs();
      ViewBag.MainTitle = "List of my favorite Songs!";
      return View(songs);
    }
    private List<SongModel> GetListOfSongs()
    {
      List<SongModel> songs = new List<SongModel>();
      songs.Add(new SongModel
      {
        Name = "Where is my mind",
        Genre = "Rock",
        Author = "Pixies",
        Duration = "3:53",
        year = 1980
      });
      return songs;
    }
  }
}
