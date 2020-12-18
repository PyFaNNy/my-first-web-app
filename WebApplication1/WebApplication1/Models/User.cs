using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User :IdentityUser<Guid>
    {
        public string Login { get; set; }
        public string Status { get; set; }
        public DateTime dateReg { get; set; }
        public DateTime dateLog { get; set; }
    }
}
