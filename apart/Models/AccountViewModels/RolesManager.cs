using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Restaurant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.AccountViewModels
{
    public class ApplicationRole : IdentityRole<Guid>
    {
    }

    public class RolesManager
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _rolesManager;
        private readonly ILogger _logger;

        public RolesManager(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
             ILoggerFactory loggerFactory)
        {
            _context = context;
            _userManager = userManager;
            _rolesManager = roleManager;
            _logger = loggerFactory.CreateLogger<RolesManager>();
        }

        public async Task CreateRoles()
        {
           
            var adminRole = "Admin";
           

            
                var adminUser = await _userManager.FindByEmailAsync("ewelina7g@gmail.com");
              
                    await _userManager.AddToRoleAsync(adminUser, adminRole);
                    //
                    
              
            
        }
    }
}
