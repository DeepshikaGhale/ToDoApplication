using System.Diagnostics;
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
        List<ToDo> todos = _todoContext.ToDos.ToList();
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

    //create action to update the todo status
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update_Status(int? Id)
    {
        var toDo = await _todoContext.ToDos.FindAsync(Id);
        if (toDo == null)
        {
            return NotFound();
        }
        toDo.IsComplete = true;
        toDo.CompletionDate = DateTime.Now;
        _todoContext.Update(toDo);

        await _todoContext.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    //binding the data
    //posts the data to the database ToDos table
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Title, IsComplete, CompletionDate")] ToDo toDo)
    {
        if (ModelState.IsValid)
        {
            //setting the value of the completion date programmatically
            if(toDo.IsComplete == true)
            {
                toDo.CompletionDate = DateTime.Now;
                _todoContext.Add(toDo);
                await _todoContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _todoContext.Add(toDo);
            await _todoContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return RedirectToAction(nameof(Index), toDo);
    }
}

