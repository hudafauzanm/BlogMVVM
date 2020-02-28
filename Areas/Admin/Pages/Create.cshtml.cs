using System;
using System.IO;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        public async Task<IActionResult> OnPostAsync(string title,string categories,string content,[FromForm(Name ="url_img")]IFormFile url_img,string userid,string author)
        {
            if(!System.IO.Directory.Exists("wwwroot" + "/Image/"))
            {
               System.IO.Directory.CreateDirectory("wwwroot" + "/Image/"); 
            }
            string storePath = "wwwroot/Image/";
            if(url_img != null)
            {
               var path = Path.Combine(storePath,url_img.FileName);
               using (var stream = new FileStream(path, FileMode.Create))
                {
                    await url_img.CopyToAsync(stream);
                }
                var pathfix = path.Substring(8);
                Article article = new Article()
                {
                    title = title,
                    categories = categories,
                    content = content,
                    url_img = pathfix,
                    UserId = userid,
                    created_at = DateTime.Now,
                    author = author
                };
                AppDbContext.Articles.Add(article);
            }
            await AppDbContext.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}