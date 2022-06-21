using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapplication6.Models;

namespace Webapplication6
{
    [Route("api/[controller]")]
    [ApiController]
    public class employee : ControllerBase
    {
        public string Id { get; private set; }

        public List<Employeetable> Get()
        {
            InformationContext db = new InformationContext();
            return db.Employeetables.ToList();
        }

       
    }
}