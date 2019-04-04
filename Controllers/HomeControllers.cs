    using Microsoft.AspNetCore.Mvc;
    namespace HomeControllers.Controllers
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public string Index()
            {
                return "Hello this is my index!";
            }

            [HttpGet]
            [Route("projects")]
            public string Pro()
            {
                return "These are my projects";
            }

            [HttpGet]
            [Route("contact")]
            public string cont()
            {
                return "This is my Contact!";
            }
        }
    }