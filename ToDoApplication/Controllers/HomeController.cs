﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoApplication.Models;
using ToDoApplication.Data;

namespace ToDoApplication.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    //initialize context class
    ToDoContext _todoContext;


    public HomeController(ILogger<HomeController> logger, ToDoContext todoContext)
    {
        _logger = logger;
        _todoContext = todoContext;

    }

    public IActionResult Index()
    {
        // get data from the todos table and
        //passes the records where the task is incomplete
        List<ToDo> todos = _todoContext.ToDos.Where(c => c.IsComplete == false).ToList();
        //pass the filtered list
        ViewBag.Todos = todos;
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

