using di_demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace di_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        //  Products pObj = new Products(); //use DI instead


        //this is the same code you get by default when you use EF Core
        Products pObj;

        public ProductController(Products _pObjREF)
        {
            pObj = _pObjREF;
        }

        [HttpGet]
        [Route("/products/list")]
        public IActionResult GetAllProducts()
        {
            return Ok(pObj.GetAllProducts());
        }
    }
}
