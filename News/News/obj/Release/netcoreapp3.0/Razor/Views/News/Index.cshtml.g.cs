#pragma checksum "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "072f774858b45f350bb00d4fa94b38a3e36ec5bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "C:\Users\ADMIN\source\repos\News\News\Views\_ViewImports.cshtml"
using News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\source\repos\News\News\Views\_ViewImports.cshtml"
using News.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072f774858b45f350bb00d4fa94b38a3e36ec5bc", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49202278a3870a90142506eb5694186b602837c", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""inner-wrap clearfix"">
    <div class=""front-page-top-section clearfix"">
        <div class=""widget_slider_area""></div>
        <div class=""widget_beside_slider""></div>
    </div>
    <div class=""main-content-section clearfix"">
        <div id=""primary"">
            <div id=""content"" class=""clearfix"">
                <header class='page-header'><h1 class='page-title'><span>");
#nullable restore
#line 9 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
                                                                     Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1></header>\r\n                <div class=\"article-container\">\r\n");
#nullable restore
#line 11 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
                      int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
                     foreach (var item in Model.LsNew)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <article class='post-239 post type-post status-publish format-standard has-post-thumbnail hentry category-science tag-beautiful-towns tag-south-africa'>
                            <div class='featured-image'>
                                <a");
            BeginWriteAttribute("href", " href=\'", 872, "\'", 954, 6);
#nullable restore
#line 16 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 879, Model.URL, 879, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 891, "/category/", 891, 10, true);
#nullable restore
#line 16 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 901, item.Category.UrlFriendly, 901, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 929, "/", 929, 1, true);
#nullable restore
#line 16 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 930, item.UrlFriendly, 930, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 949, ".html", 949, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\'", 955, "\'", 980, 1);
#nullable restore
#line 16 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 963, item.TitleNews, 963, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("width", " width=\'", 1024, "\'", 1053, 1);
#nullable restore
#line 17 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1032, i == 0 ? 800 : 445, 1032, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\'445\'");
            BeginWriteAttribute("src", " src=\'", 1067, "\'", 1087, 1);
#nullable restore
#line 17 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1073, item.UrlImg, 1073, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\'attachment-colormag-featured-image size-colormag-featured-image wp-post-image\'");
            BeginWriteAttribute("alt", " alt=\'", 1174, "\'", 1197, 1);
#nullable restore
#line 17 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1180, item.TitleNews, 1180, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </a>\r\n                            </div>\r\n                            <div class=\'article-content clearfix\'>\r\n                                <div class=\'above-entry-meta\'><span class=\'cat-links\'><a");
            BeginWriteAttribute("href", " href=\'", 1431, "\'", 1489, 4);
#nullable restore
#line 21 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1438, Model.URL, 1438, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1450, "/category/", 1450, 10, true);
#nullable restore
#line 21 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1460, item.Category.UrlFriendly, 1460, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1488, "/", 1488, 1, true);
            EndWriteAttribute();
            WriteLiteral(" rel=\'category tag\'>");
#nullable restore
#line 21 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
                                                                                                                                                                   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>&nbsp;</span></div>\r\n                                <header class=\'entry-header\'>\r\n                                    <h2 class=\'entry-title\'>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\'", 1731, "\'", 1813, 6);
#nullable restore
#line 24 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1738, Model.URL, 1738, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1750, "/category/", 1750, 10, true);
#nullable restore
#line 24 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1760, item.Category.UrlFriendly, 1760, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1788, "/", 1788, 1, true);
#nullable restore
#line 24 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1789, item.UrlFriendly, 1789, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1808, ".html", 1808, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\'", 1814, "\'", 1839, 1);
#nullable restore
#line 24 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 1822, item.TitleNews, 1822, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
                                                                                                                                                    Write(item.TitleNews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h2>\r\n                                </header>\r\n                                <div class=\'entry-content clearfix\'>\r\n                                    <p>");
#nullable restore
#line 28 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
                                  Write(Html.Raw(item.DescriptionNews));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a class=\'more-link\'");
            BeginWriteAttribute("title", " title=\'", 2152, "\'", 2177, 1);
#nullable restore
#line 29 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 2160, item.TitleNews, 2160, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\'", 2178, "\'", 2260, 6);
#nullable restore
#line 29 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 2185, Model.URL, 2185, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2197, "/category/", 2197, 10, true);
#nullable restore
#line 29 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 2207, item.Category.UrlFriendly, 2207, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2235, "/", 2235, 1, true);
#nullable restore
#line 29 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
WriteAttributeValue("", 2236, item.UrlFriendly, 2236, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2255, ".html", 2255, 5, true);
            EndWriteAttribute();
            WriteLiteral("><span>Read more</span></a>\r\n                                </div>\r\n                            </div>\r\n                        </article>\r\n");
#nullable restore
#line 33 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
                        i++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 38 "C:\Users\ADMIN\source\repos\News\News\Views\News\Index.cshtml"
   Write(await Html.PartialAsync("_RightNavBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
