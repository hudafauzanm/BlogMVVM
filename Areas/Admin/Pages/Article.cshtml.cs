using Blog.Data;
using Blog.Model;
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
    public class ArticleAdminModel : PageModel
    {
        public ApplicationDbContext AppDbContext {get;set;}
        private readonly ILogger<ArticleAdminModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public ArticleAdminModel(ILogger<ArticleAdminModel> logger,UserManager<IdentityUser> userManager,ApplicationDbContext appDbContext)
        {
            AppDbContext = appDbContext;
            _userManager = userManager;
            _logger = logger;
        }
        public void OnGet(string id)
        {
            var art = from a in AppDbContext.Articles where a.id == Guid.Parse(id) select a;
            var comment = (from com in AppDbContext.Comments from user in AppDbContext.Users where com.article_id == id select com).Distinct();
            var userid = _userManager.GetUserId(User);
            var username = User.Identity.Name;
            ViewData["User"] = username;
            ViewData["Comment"] = comment;
            ViewData["ArticleId"] = id;
            ViewData["UserId"] = userid;
            ViewData["Articles"] = art;
        }

        public async Task<IActionResult> OnPostAsync(string comments,string commenter_id,string articles_id,string commenter_name)
        {
            Comment comment = new Comment()
            {
                comment = comments,
                commenter_id = commenter_id,
                article_id = articles_id,
                comment_name = commenter_name

            };
            AppDbContext.Comments.Add(comment);
            await AppDbContext.SaveChangesAsync();
            return Redirect("https://localhost:5001/Admin/Article?id="+articles_id);
        }

    }
}