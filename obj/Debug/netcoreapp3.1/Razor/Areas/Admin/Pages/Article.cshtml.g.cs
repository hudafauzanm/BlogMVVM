#pragma checksum "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55bd920c9cc4435180b8aedf82ca75d2fb22a946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Blog.Pages.Areas_Admin_Pages_Article), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Article.cshtml")]
namespace Blog.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\_ViewImports.cshtml"
using Blog.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55bd920c9cc4435180b8aedf82ca75d2fb22a946", @"/Areas/Admin/Pages/Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51afbd44705e84b4f516b3a657de96341c0a8a9", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Article : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n      <!-- Post Content Column -->\r\n      <div class=\"col-lg-8\">\r\n\r\n        <!-- Title -->\r\n");
#nullable restore
#line 11 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
          
          ViewBag.Article = ViewData["Articles"];
          foreach(var art in ViewBag.Article)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <h1 class=\"mt-4\">");
#nullable restore
#line 15 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                          Write(art.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("              <p class=\"lead\">\r\n                Categories\r\n                <a href=\"#\">");
#nullable restore
#line 19 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                       Write(art.categories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n              </p>\r\n");
            WriteLiteral("              <hr>\r\n");
            WriteLiteral("              <p>Posted on ");
#nullable restore
#line 24 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                      Write(art.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("              <hr>\r\n");
            WriteLiteral("              <img class=\"img-fluid rounded\"");
            BeginWriteAttribute("src", " src=", 667, "", 684, 1);
#nullable restore
#line 28 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
WriteAttributeValue("", 672, art.url_img, 672, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 684, "\"", 690, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("              <hr>\r\n");
            WriteLiteral("              <span>");
#nullable restore
#line 32 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
               Write(art.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("              <hr>\r\n");
#nullable restore
#line 35 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
          }
              
      

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n      \r\n              <!-- Comments Form -->\r\n              <div class=\"card my-4\">\r\n                <h5 class=\"card-header\">Leave a Comment:</h5>\r\n                <div class=\"card-body\">\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55bd920c9cc4435180b8aedf82ca75d2fb22a9466543", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n");
#nullable restore
#line 46 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                       
                         ViewBag.User = ViewData["UserId"];
                         ViewBag.ArticlesId = ViewData["ArticleId"];

#line default
#line hidden
#nullable disable
                WriteLiteral("                         <input type=\"text\" name=\"articles_id\"");
                BeginWriteAttribute("value", " value=", 1345, "", 1371, 1);
#nullable restore
#line 49 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
WriteAttributeValue("", 1352, ViewBag.ArticlesId, 1352, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                         <input type=\"text\" name=\"commenter_id\"");
                BeginWriteAttribute("value", " value=", 1444, "", 1464, 1);
#nullable restore
#line 50 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
WriteAttributeValue("", 1451, ViewBag.User, 1451, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n");
                WriteLiteral("                      <textarea class=\"form-control\" name=\"comments\" rows=\"3\"></textarea>\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n              </div>\r\n");
#nullable restore
#line 58 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                
                  ViewBag.Comment = ViewData["Comment"];
                  

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                   foreach(var co in ViewBag.Comment)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <div class=\"media mb-4\">\r\n                      <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 2069, "\"", 2075, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                          <h5 class=\"mt-0\">");
#nullable restore
#line 64 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                                      Write(co.commenter_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                          <br></br>\r\n                         ");
#nullable restore
#line 66 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                    Write(co.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      </div>\r\n");
#nullable restore
#line 68 "D:\Users\bsi50128\Belajar\Blog\Areas\Admin\Pages\Article.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      </div>

      <!-- Sidebar Widgets Column -->
      <div class=""col-md-4"">

        <!-- Search Widget -->
        <div class=""card my-4"">
          <h5 class=""card-header"">Search</h5>
          <div class=""card-body"">
            <div class=""input-group"">
              <input type=""text"" class=""form-control"" placeholder=""Search for..."">
              <span class=""input-group-btn"">
                <button class=""btn btn-secondary"" type=""button"">Go!</button>
              </span>
            </div>
          </div>
        </div>

        <!-- Categories Widget -->
        <div class=""card my-4"">
          <h5 class=""card-header"">Categories</h5>
          <div class=""card-body"">
            <div class=""row"">
              <div class=""col-lg-6"">
                <ul class=""list-unstyled mb-0"">
                  <li>
                    <a href=""#"">Web Design</a>
                  </li>
                  <li>
                    <a href=""#"">HTML</a>
                  </li>
   ");
            WriteLiteral(@"               <li>
                    <a href=""#"">Freebies</a>
                  </li>
                </ul>
              </div>
              <div class=""col-lg-6"">
                <ul class=""list-unstyled mb-0"">
                  <li>
                    <a href=""#"">JavaScript</a>
                  </li>
                  <li>
                    <a href=""#"">CSS</a>
                  </li>
                  <li>
                    <a href=""#"">Tutorials</a>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>

        <!-- Side Widget -->
        <div class=""card my-4"">
          <h5 class=""card-header"">Side Widget</h5>
          <div class=""card-body"">
            You can put anything you want inside of these side widgets. They are easy to use, and feature the new Bootstrap 4 card containers!
          </div>
        </div>

      </div>

    </div>
    <!-- /.row -->
  </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas.Admin.Pages.ArticleAdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas.Admin.Pages.ArticleAdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas.Admin.Pages.ArticleAdminModel>)PageContext?.ViewData;
        public Areas.Admin.Pages.ArticleAdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591