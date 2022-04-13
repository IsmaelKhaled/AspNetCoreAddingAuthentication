using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WishList.Models
{
    public class ApplicationUser : IdentityUser
    {
        virtual public ICollection<Item> Items { get; set; }
    }
}
