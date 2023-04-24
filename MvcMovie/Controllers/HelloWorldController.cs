using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
          Handles browser requests
          Retreive model data
          Call view templates that return a response
        */

        /*
         * The controller class is where the code is 
         * written that handles the incoming browser requests.
         */

        /*
         * The controller retrieves data from a data source and 
         * decides what types of response to send back to the browser.
         */

        public IActionResult Index()
            // IActionResult defines a contract that represents the result of an action method.
        {
            // calls the controller's view method.
            return View();
        }


        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            // ViewData dictionary object contains data that will be passed to the view.
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
