using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain
{
    public class User: IdentityUser<int>
    {
        public ICollection<Note> Notes { get; set; }
    }
}
