using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebApplication1core.Models.Identity;

namespace WebApplication1core.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

    }
}
