using Microsoft.AspNetCore.Mvc;
using Project_Structure.Models;

namespace Project_Structure.Controllers
{
    public class MoviesController : Controller
    {


        public IActionResult GetMovie(int id)
        {
            if (id < 10)
            {
                return BadRequest();
            }

            if (id == 100) {
                return NotFound();
            }
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie with id = {id}";
            return Content($"Movie with id = {id}","text/html");

            //BadRequestResult result02 = new BadRequestResult();
            //return result02;
            //UnauthorizedResult result03 = new UnauthorizedResult();
            //return result03;
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie with id = {id}";
            //result.ContentType = "text/html";
            //result.ContentType = "object/pdf";
            //return result;
            //return $"Movie with id = {id}";
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    ViewResult result = new ViewResult();
        //    result.ViewName = "Create"; 
        //    return View(result);
        //}

        //[HttpPost]
        //public IActionResult Create(Movie movie)
        //{
          
        //}
    }
}
