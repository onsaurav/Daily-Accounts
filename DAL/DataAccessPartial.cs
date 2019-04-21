using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Company
    {
        public bool IsSelected { get; set; }
    }

    public partial class ControlAccount
    {
        public bool IsSelected { get; set; }
    }

    public partial class Location
    {
        public bool IsSelected { get; set; }
    }

    public partial class User
    {
        public bool IsSelected { get; set; }
        public string LocationId { get; set; }
    }
    
}
