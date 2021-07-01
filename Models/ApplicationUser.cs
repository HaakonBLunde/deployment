using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace sykeplayer_1.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Nickname { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}