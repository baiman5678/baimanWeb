using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace bobproject.Data
{
    public class ApplicationUsers : IdentityUser
    {
        public int Age { get; set; }


        [MaxLength(5)]
        public string Gender { get; set; }
        [MaxLength(5)]
        public string City { get; set; }
        

    }
}
