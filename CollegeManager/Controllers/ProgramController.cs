
using Microsoft.AspNetCore.Mvc;
public class ProgramController : Controller
{
    List<CollegeProgram> programs = 
    [
        new() { Id = 1, Name = "CSIT", Affliation = "TU", Started = DateTime.Now },
        new() { Id = 2, Name = "BCA", Affliation = "TU", Started = DateTime.Now.AddYears(-2) },
        new() { Id = 3, Name = "BIT", Affliation = "TU", Started = DateTime.Now.AddMonths(-11) },
        new() { Id = 4, Name = "BIM", Affliation = "PU", Started = DateTime.Now.AddDays(-200) },


    ];
    [HttpGet]
    public IActionResult Index()
    {
       
        return View(programs);
    }
    [HttpGet] //supports http 'get' attribute
    public IActionResult Add()
    {
        return View();
    }
     [HttpPost]
      public IActionResult Add(CollegeProgram program) //model binding
    {
        // Do something on program
        program.Add(programs);
        return RedirectToAction("Index");
    }

}