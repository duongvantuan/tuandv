#pragma checksum "C:\Users\ADMIN\source\repos\News\News\Views\Shared\_RightNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6cd035dc322888df9872a7cde04c16df373b919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RightNavBar), @"mvc.1.0.view", @"/Views/Shared/_RightNavBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6cd035dc322888df9872a7cde04c16df373b919", @"/Views/Shared/_RightNavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49202278a3870a90142506eb5694186b602837c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RightNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://www.google.com/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cse-search-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div id=\"secondary\">\r\n    <aside id=\"text-2\" class=\"widget widget_text clearfix\">\r\n        <h3 class=\"widget-title\"><span>Search By Google</span></h3>\r\n        <div class=\"textwidget\">\r\n            <style type=\"text/css\">\r\n");
            WriteLiteral("            </style>\r\n            <div class=\"cse-branding-bottom\" style=\"background-color:#FFFFFF;color:#000000\">\r\n                <div class=\"cse-branding-form\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6cd035dc322888df9872a7cde04c16df373b9194379", async() => {
                WriteLiteral(@"
                        <div>
                            <input type=""hidden"" name=""cx"" value=""006236088925092053547:whft8zbmm2l"">
                            <input type=""hidden"" name=""ie"" value=""UTF-8"">
                            <input type=""text"" name=""q"" size=""55"">
                            <input type=""submit"" name=""sa"" value=""Search"">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""cse-branding-logo""></div>
                <div class=""cse-branding-text"">
                    Custom Search
                </div>
            </div>
        </div>
    </aside>
    <aside id=""text-3"" class=""widget widget_text clearfix"">
        <div class=""textwidget"">
            <!-- Hinh Vuong -->
            <!-- 336x280 -->
            ");
#nullable restore
#line 30 "C:\Users\ADMIN\source\repos\News\News\Views\Shared\_RightNavBar.cshtml"
       Write(Html.Raw(Model.ads2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </aside>\r\n    <aside id=\"recent-posts-2\" class=\"widget widget_recent_entries clearfix\">\r\n        <h3 class=\"widget-title\"><span>Recent Posts</span></h3>\r\n        <ul>\r\n");
#nullable restore
#line 36 "C:\Users\ADMIN\source\repos\News\News\Views\Shared\_RightNavBar.cshtml"
             foreach (var item in Model.LsNewRecent)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\'", 1678, "\'", 1760, 6);
#nullable restore
#line 38 "C:\Users\ADMIN\source\repos\News\News\Views\Shared\_RightNavBar.cshtml"
WriteAttributeValue("", 1685, Model.URL, 1685, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1697, "/category/", 1697, 10, true);
#nullable restore
#line 38 "C:\Users\ADMIN\source\repos\News\News\Views\Shared\_RightNavBar.cshtml"
WriteAttributeValue("", 1707, item.Category.UrlFriendly, 1707, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1735, "/", 1735, 1, true);
#nullable restore
#line 38 "C:\Users\ADMIN\source\repos\News\News\Views\Shared\_RightNavBar.cshtml"
WriteAttributeValue("", 1736, item.UrlFriendly, 1736, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1755, ".html", 1755, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\ADMIN\source\repos\News\News\Views\Shared\_RightNavBar.cshtml"
                                                                                                      Write(item.TitleNews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 39 "C:\Users\ADMIN\source\repos\News\News\Views\Shared\_RightNavBar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </aside>\r\n</div>");
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
