using EcommerceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceDbContext db;
        public ProductController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return db.Products;
        }

        [HttpPost]
        public string Post([FromBody] Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] Product product)
        {

            var productObj = db.Products.Where(x => x.Id == product.Id);
            if (productObj != null)
            {
                db.Products.Update(product);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {

            var productObj = db.Products.Where(x => x.Id == Id).FirstOrDefault();
            if (productObj != null)
            {
                db.Products.Remove(productObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
