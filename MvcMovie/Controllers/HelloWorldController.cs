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
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            //https://localhost:{PORT}/HelloWorld/Welcome/3?name=Rick
        }
    }
}
