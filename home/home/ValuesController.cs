using home.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace home
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public List<Table1p> Get()
        {
            InformationContext db = new InformationContext();
            return db.Table1ps.ToList();
        }

    }
}
