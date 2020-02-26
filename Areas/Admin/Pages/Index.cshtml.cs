using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Blog.Areas.Admin.Pages
{
    public class IndexAdminModel : PageModel
    {
        public ApplicationDbContext AppDbContext {get;set;}
        private readonly ILogger<IndexAdminModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexAdminModel(ILogger<IndexAdminModel> logger,UserManager<IdentityUser> userManager,ApplicationDbContext appDbContext)
        {
            AppDbContext = appDbContext;
            _userManager = userManager;
            _logger = logger;
        }

        public void OnGet()
        { 
            var userid = _userManager.GetUserId(User);
            var articles = from art in AppDbContext.Articles where art.UserId == userid select art;
            ViewData["Articles"] = articles;
            ViewData["UserId"] = userid;
        }

        public async Task<IActionResult> OnPostAsync(string deleteid,string editid,string title,string category,string content,string url_img )
        {
            if(deleteid != null)
            {
                Console.WriteLine("masuk delete");
                var iddelete = Guid.Parse(deleteid);
                var delete = AppDbContext.Articles.Find(iddelete);
                AppDbContext.Remove(delete);
            }
            if(editid != null)
            {
                Console.WriteLine("Masuk edit");
                var idedit = Guid.Parse(editid);
                var edit = AppDbContext.Articles.Find(idedit);
                edit.title = title;
                edit.categories = category;
                edit.content = content;
                edit.url_img = url_img;
            }
            await AppDbContext.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}
