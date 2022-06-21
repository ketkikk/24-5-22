using System;
using System.Collections.Generic;

#nullable disable

namespace Webapplication6.Models
{
    public partial class Employeetable
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Text { get; internal set; }
    }
}
