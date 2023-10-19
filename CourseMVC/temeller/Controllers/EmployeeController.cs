using Microsoft.AspNetCore.Mvc;
using temeller.Models;

namespace temeller.Controllers
{

public class EmployeeController : Controller
    {
    
        public IActionResult Index1()
        {

        string message = $"Merhaba. {DateTime.Now.ToString()}";
        return View("Index1" ,message);           // String Döndürür


        }

        public ViewResult Index2()
        {

        var names = new String[]
        {
            "Buğra",
            "Kübra",
            "Bahar",
            "Davut"


        };
        
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {

                new Employee(){Id=1, FirstName="Bugra" , LastName="Alp", Age=24},
                new Employee(){Id=2, FirstName="Sena" , LastName="Nur", Age=22},
                new Employee(){Id=3, FirstName="Feyza" , LastName="Filizay", Age=23},

            };


            return View("Index3", list);         // İçerik Döndürür


        }


    }

}