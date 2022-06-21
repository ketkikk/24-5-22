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
    public class AdminController : ControllerBase
    {
        EcommerceDbContext db;
        public AdminController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return db.Admins;
        }
        [HttpPost]
        public string Post([FromBody] Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] Admin admin)
        {

            var userObj = db.Admins.Where(x => x.Id == admin.Id);
            if (userObj != null)
            {
                db.Admins.Update(admin);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {

            var adminObj = db.Admins.Where(x => x.Id == Id).FirstOrDefault();
            if (adminObj != null)
            {
                db.Admins.Remove(adminObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}