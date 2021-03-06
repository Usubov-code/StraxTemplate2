using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StraxTemplate.Models
{
    public class CustomUser: IdentityUser
    {
        
        [MaxLength(50),Required]
        public string Name { get; set; }
      
        public List<Service> Services { get; set; }
    }
}
