using Blog.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Areas.Admin.Pages
{
    public class RoleAdminModel : PageModel
    {
        public ApplicationDbContext AppDbContext {get;set;}
        private readonly ILogger<RoleAdminModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public RoleAdminModel(ILogger<RoleAdminModel> logger,UserManager<IdentityUser> userManager,ApplicationDbContext appDbContext,RoleManager<IdentityRole> roleManager)
        {
            AppDbContext = appDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        public void OnGet()
        {
            var roles = _roleManager.Roles;
            var user = from us in AppDbContext.Users select us;
            var user_role = from ur in AppDbContext.UserRoles select ur;
            foreach(var hasil in user_role)
            {
                var nama = from n in AppDbContext.Users where n.Id == hasil.UserId select n.UserName;
                var role = from r in AppDbContext.Roles where r.Id == hasil.RoleId select r.Name;
                ViewData["Nama"] = nama;
                ViewData["RoleUser"] = role;
            }
            ViewData["Role"] = roles;
            ViewData["User"] = user;
        }

        public async Task<IActionResult> OnPostAsync(string role_name,string delete_id,string user_id,string roleuser)
        {
            if(role_name != null)
            {
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(role_name));
            }
            if(delete_id != null)
            {
                IdentityRole role = await _roleManager.FindByIdAsync(delete_id);
                if (role != null)
                {
                    IdentityResult result = await _roleManager.DeleteAsync(role);
                }
            }
            if(user_id != null && roleuser != null)
            {
                var user = await _userManager.FindByIdAsync(user_id);
                await _userManager.AddToRoleAsync(user,roleuser);
            }
            return RedirectToPage("/Role");
        }
    }
}