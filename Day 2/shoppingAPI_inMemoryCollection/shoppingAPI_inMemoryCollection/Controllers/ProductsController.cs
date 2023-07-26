using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shoppingAPI_inMemoryCollection.Entities;
namespace shoppingAPI_inMemoryCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Products pObj = new Products(); //we should use DI instead

        #region Get Products

        [HttpGet]
        [Route("/products")]
        public IActionResult GetallProducts()
        {
            return Ok(pObj.GetAllProducts());
        }


        [HttpGet]
        [Route("/products/id/{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                var prod = pObj.GetproductById(id);
                return Ok(prod);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }


        [HttpGet]
        [Route("/products/category/{category}")]
        public IActionResult GetProductByCategory(string category)
        {
            try
            {
                var products = pObj.GetProductByCategory(category);
                return Ok(products);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }

        [HttpGet]
        [Route("/products/total")]
        public IActionResult GettotalProducts()
        {
            var total = pObj.GetTotalProducts();
            return Ok(total);
        }

        #endregion

        #region Add, Update and Delete

        [HttpPost]
        [Route("/products/add")]
        public IActionResult AddProduct(Products newProduct)
        {
            var result = pObj.AddProduct(newProduct);
            return Created("", result);
        }
        [HttpPut]
        [Route("/products/edit")]
        public IActionResult UpdateProduct(Products changes)
        {
            try
            {
                var result = pObj.UpdateProduct(changes);
                return Accepted(result);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }
        [HttpDelete]
        [Route("/products/delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var result = pObj.DeleteProduct(id);
                return Accepted(result);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
                
            }
        }
        #endregion
    }

}






