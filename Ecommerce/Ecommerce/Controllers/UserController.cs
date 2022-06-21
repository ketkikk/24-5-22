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
    public class UserController : ControllerBase
    {
        EcommerceDbContext db;
        public UserController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users;
        }

        [HttpPost]
        public string Post([FromBody] User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return "success";
        }

        [HttpPut]
        public string Put([FromBody] User user)
        {

            var userObj = db.Users.Where(x => x.Id == user.Id);
            if (userObj != null)
            {
                db.Users.Update(user);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {

            var userObj = db.Users.Where(x => x.Id == Id).FirstOrDefault();
            if (userObj != null)
            {
                db.Users.Remove(userObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}