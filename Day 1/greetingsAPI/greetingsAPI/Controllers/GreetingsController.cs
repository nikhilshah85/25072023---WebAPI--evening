using greetingsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace greetingsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        [Route("/greet")]
        public IActionResult Greetings()
        {
            //methods will always return Http Status Code and Message/data

            return Ok("Hello and welcome to webapi developers world");
        }


        [HttpGet]
        [Route("/greet/{guestName}")]
        public IActionResult Greetings(string guestName)
        {
            return Ok("Hello " + guestName);
        }


        [HttpGet]
        [Route("/friends")]
        public IActionResult Friendslist()
        {
            string[] friends = new string[5];
            friends[0] = "Akshay";
            friends[1] = "Priya";
            friends[2] = "Riya";
            friends[3] = "Jiya";
            friends[4] = "Divya";
            return Ok(friends);
        }

        [HttpGet]
        [Route("/introduction")]
        public IActionResult AboutMe()
        {
            var myInfo = new
            {
                firstName = "Nikhil",
                lastName = "Shah",
                city = "Mumbai",
                edu = "MCA",
                profession = "Consultant and trainer"                
            };

            return Ok(myInfo);

        }

        [HttpGet]
        [Route("/product")]
        public IActionResult GetProductInfo()
        {
            ProductDetails pObj = new ProductDetails(); //this is a crime, not a good practice, use DI instead
            var data = pObj.Getproductinfo();
            return Ok(data);
        }

    }
}








