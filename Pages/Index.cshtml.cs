using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Blog.Pages
{
    public class IndexModel : PageModel
    {
        public ApplicationDbContext AppDbContext {get;set;}
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(ILogger<IndexModel> logger,UserManager<IdentityUser> userManager,ApplicationDbContext appDbContext)
        {
            AppDbContext = appDbContext;
            _userManager = userManager;
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            var userid = _userManager.GetUserId(User);
            var userrole = from x in AppDbContext.UserRoles where x.UserId == userid select x.RoleId;
            foreach(var u in userrole)
            {
                if(u == "6fc7c074-162c-4cfe-976a-c3247c85eb9c")
                {
                    var article = from art in AppDbContext.Articles orderby art.created_at descending select art;
                    ViewData["Articles"] = article;
                }
                if(u == "a968363c-7a6d-43fe-aed3-5cf08c65e092")
                {
                    var article = from art in AppDbContext.Articles orderby art.created_at descending select art;
                    ViewData["Articles"] = article;
                }
                if(u == "ff6245f1-8088-4f48-9c20-81021f6c4f7b")
                {
                    return Redirect("https://localhost:5001/Admin");
                }
            }
            var articles = from art in AppDbContext.Articles orderby art.created_at descending select art;
            ViewData["Articles"] = articles;
            return Page();
        }
    }
}
