#pragma checksum "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c003e91afc2b7dbeacc3daa8deaf5ff221667e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperHeroCorrection_Index), @"mvc.1.0.view", @"/Views/SuperHeroCorrection/Index.cshtml")]
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
#line 1 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\_ViewImports.cshtml"
using atelierApiRest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\_ViewImports.cshtml"
using atelierApiRest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c003e91afc2b7dbeacc3daa8deaf5ff221667e2", @"/Views/SuperHeroCorrection/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78aea6b01b5d99faa14231cd912d49b6e4ca9280", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperHeroCorrection_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hero>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Heroes</h1>\r\n\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 10 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
     foreach(Hero hero in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card \">\r\n        <div class=\"d-flex\">\r\n            <div>\r\n                <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 313, "\"", 335, 1);
#nullable restore
#line 15 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
WriteAttributeValue(" ", 319, hero.Image.Url, 320, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-5\">\r\n                <p>\r\n                    ");
#nullable restore
#line 19 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
               Write(hero.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p> \r\n                <p>\r\n                    ");
#nullable restore
#line 22 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
               Write(hero.Biography.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <p>\r\n                durability:  ");
#nullable restore
#line 28 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
                        Write(hero.Powerstats.durability);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                   power  ");
#nullable restore
#line 31 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
                     Write(hero.Powerstats.power);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n           <p>\r\n                intelligence: ");
#nullable restore
#line 34 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
                         Write(hero.Powerstats.intelligence);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 38 "D:\Documents\wild\workSpace\quetesCsharp\atelierApiRest\atelierApiRest\Views\SuperHeroCorrection\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hero>> Html { get; private set; }
    }
}
#pragma warning restore 1591
