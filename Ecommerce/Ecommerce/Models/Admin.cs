using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string AdminCode { get; set; }
        public string AdminName { get; set; }
        public int AdminAmount { get; set; }
    }
}
