using BookStoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookStoreMVC.Controllers;

public class BooksController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Details()
    {
        Book book = new Book()
        {
            Id = 1,
            Title = "Learning ASP.NET Core 8.0",
            Genre = "Programming & Software Development",
            Price = 45,
            PublishDate = new System.DateTime(2025, 05, 21),
            Authors = new List<string> { "Jason De Oliveira", "Michel Bruchet" }
        };
        return View(book);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Book book)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("Index");
        }
        return View(book);
    }
}
