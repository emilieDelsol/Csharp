#pragma checksum "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2264550e41233f138d19e24a57275721fe8456cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Test), @"mvc.1.0.view", @"/Views/Blog/Test.cshtml")]
namespace AspNetCore
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
#line 1 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\_ViewImports.cshtml"
using apiRestFullHtml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\_ViewImports.cshtml"
using apiRestFullHtml.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2264550e41233f138d19e24a57275721fe8456cd", @"/Views/Blog/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9121a85b5db22b6be7c08ca4d6b21e306dd85e2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserArticlesPhotos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
  
    ViewData["Title"] = "test";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Il y a ");
#nullable restore
#line 7 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
      Write(Model.Articles.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" articles: </h1>\r\n<div class=\"container-fluid\">\r\n");
#nullable restore
#line 9 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
     foreach (Article article in @Model.Articles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-4 p-4\">\r\n\r\n            <h1>");
#nullable restore
#line 13 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
           Write(article.Post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p>");
#nullable restore
#line 14 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
          Write(article.Post.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <p>
                <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
                    Click to see comments
                </a>
            </p>
            <div class=""collapse"" id=""collapseExample"">
");
#nullable restore
#line 21 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
                 foreach (var comment in @article.ListComments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card card-body\">\r\n                        <p>");
#nullable restore
#line 24 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
                      Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" à écrit:</p>\r\n                        <p>");
#nullable restore
#line 25 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
                      Write(comment.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 27 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"container-fluid\">\r\n");
#nullable restore
#line 34 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
     foreach(UserAlbum userAlbum in Model.userAlbums)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h2>Album n° ");
#nullable restore
#line 37 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
                Write(userAlbum.AlbumId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" il y a  ");
#nullable restore
#line 37 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
                                           Write(userAlbum.PhotosList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" photos:</h2>\r\n\r\n        <div class=\"container-fluid d-flex justify-content-around flex-wrap\">\r\n");
#nullable restore
#line 40 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
             foreach (var photos in userAlbum.PhotosList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <p> photo title: ");
#nullable restore
#line 43 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
                            Write(photos.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p");
            BeginWriteAttribute("style", " style=\"", 1464, "\"", 1531, 4);
            WriteAttributeValue("", 1472, "height:100px;", 1472, 13, true);
            WriteAttributeValue(" ", 1485, "width:100px;", 1486, 13, true);
            WriteAttributeValue(" ", 1498, "background-image:url(", 1499, 22, true);
#nullable restore
#line 44 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
WriteAttributeValue("", 1520, photos.Url, 1520, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </p>\r\n            </div>\r\n");
#nullable restore
#line 46 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 49 "D:\Documents\wild\workSpace\quetesCsharp\apiRestFullHtml\apiRestFullHtml\Views\Blog\Test.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserArticlesPhotos> Html { get; private set; }
    }
}
#pragma warning restore 1591