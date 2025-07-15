using Microsoft.AspNetCore.Identity;

namespace MVCapp.Models
{
    public class Users : IdentityUser
    {
        public string FullName {  get; set; }
    }
}
