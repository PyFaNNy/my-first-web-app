using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User :IdentityUser
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string status { get; set; }
        public DateTime dateReg { get; set; }
        public DateTime dateLog { get; set; }
    }
}
