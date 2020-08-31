using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiScratch.Models;

namespace WebApiScratch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id=1006368,
                Name="Austin and Barbeque AAB WIFI Thermometer",
                Description="Thermometer with Wifi for an optimal temperature",
                Price=399
            },
            new Product
            {
                Id=1009334,
                Name="Andersson Electric Lighter",
                Description="Electric lighter without gas or petrol",
                Price=89
            },
            new Product
            {
                Id=1002266,
                Name="Weber Non-Sticky Spray",
                Description="BBQ Oil-Spray that prevents from sticking to the grill",
                Price=99
            }
        };

        [HttpGet] //Get All Products

        public ActionResult<IEnumerable<Product>> Get()
        {
            return products;
        }

        [HttpGet("{id}")] //Get a specific Product
        public ActionResult<Product> Get(int id)
        {
            var product = products.Find(product => product.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost] //Add New Product
        public ActionResult Post([FromBody] Product product)
        {
            if (products.Exists(prop => prop.Id == product.Id))
            {
                return Conflict();

            }
        
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, products);
        }

        [HttpDelete("{id}")] //Delete Product
        public ActionResult<IEnumerable<Product>> Delete(int id)
        {
            var product = products.Where(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            products = products.Except(product).ToList();
            return products;
        }

        [HttpPut("{id}")] //UpdateProduct
        public ActionResult<IEnumerable<Product>> Put(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            var existingProduct = products.Where(p => p.Id == id);
            products = products.Except(existingProduct).ToList();
            products.Add(product);
            return products;
        }
    }
}
