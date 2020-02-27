using System;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Blog.Areas.Admin.Pages
{
    [Authorize(Roles = "Admin")]
    public class CreateAdminModel : PageModel
    {
        public ApplicationDbContext AppDbContext {get;set;}
        private readonly ILogger<CreateAdminModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateAdminModel(ILogger<CreateAdminModel> logger,UserManager<IdentityUser> userManager,ApplicationDbContext appDbContext)
        {
            AppDbContext = appDbContext;
            _userManager = userManager;
            _logger = logger;
        }

        public void OnGet()
        {
            var userid = _userManager.GetUserId(User);
            var username = User.Identity.Name;
            Console.WriteLine(username);
            ViewData["UserId"] = userid;
            ViewData["User"] = username;
        }

        public async Task<IActionResult> OnPostAsync(string title,string categories,string content,string url_img,string userid,string author)
        {
            Article article = new Article()
            {
                title = title,
                categories = categories,
                content = content,
                url_img = url_img,
                UserId = userid,
                created_at = DateTime.Now,
                author = author
            };
            AppDbContext.Articles.Add(article);
            await AppDbContext.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}