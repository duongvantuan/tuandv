#pragma checksum "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27f648697a99382592884cda513e141cc8991550"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_News), @"mvc.1.0.view", @"/Views/News/News.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f648697a99382592884cda513e141cc8991550", @"/Views/News/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49202278a3870a90142506eb5694186b602837c", @"/Views/_ViewImports.cshtml")]
    public class Views_News_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""inner-wrap clearfix"">
    <div class=""front-page-top-section clearfix"">
        <div class=""widget_slider_area""></div>
        <div class=""widget_beside_slider""></div>
    </div>
    <div class=""main-content-section clearfix"">
        <div id='primary'>
            <div id='content' class='clearfix'>
                <article class='post-239 post type-post status-publish format-standard has-post-thumbnail hentry category-science tag-beautiful-towns tag-south-africa'>
                    <div class='article-content clearfix'>
                        <div class='above-entry-meta'><span class='cat-links'><a");
            BeginWriteAttribute("href", " href=\'", 632, "\'", 700, 4);
#nullable restore
#line 11 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
WriteAttributeValue("", 639, Model.URL, 639, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 651, "/category/", 651, 10, true);
#nullable restore
#line 11 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
WriteAttributeValue("", 661, Model.News.Category.UrlFriendly, 661, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 695, ".html", 695, 5, true);
            EndWriteAttribute();
            WriteLiteral(" rel=\'category tag\'>");
#nullable restore
#line 11 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
                                                                                                                                                                     Write(Model.News.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>&nbsp;</span></div>\r\n                        <header class=\'entry-header\'>\r\n                            <h1 class=\'entry-title\'>");
#nullable restore
#line 13 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
                                                Write(Model.News.TitleNews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </header>\r\n                        <div class=\'entry-content clearfix\'>\r\n                            <center>");
#nullable restore
#line 16 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
                               Write(Html.Raw(Model.ads1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</center>\r\n                            <figure id=\'attachment_241\' style=\'width: 630px\' class=\'wp-caption aligncenter\'>\r\n                                <img class=\'size-full wp-image-241\'");
            BeginWriteAttribute("src", " src=\'", 1260, "\'", 1286, 1);
#nullable restore
#line 18 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
WriteAttributeValue("", 1266, Model.News.UrlImg, 1266, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\'", 1287, "\'", 1316, 1);
#nullable restore
#line 18 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
WriteAttributeValue("", 1293, Model.News.TitleNews, 1293, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\'630\' height=\'474\'>\r\n                                <figcaption class=\'wp-caption-text\'>");
#nullable restore
#line 19 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
                                                                Write(Model.News.TitleNews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</figcaption>\r\n                            </figure>\r\n                            <p>");
#nullable restore
#line 21 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
                          Write(Html.Raw(Model.News.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </article>\r\n            </div>\r\n");
            WriteLiteral(@"            <div id=""comments"" class=""comments-area"">
                <div id=""respond"" class=""comment-respond"">
                    <h3 id=""reply-title"" class=""comment-reply-title"">
                        Leave a Reply <small>
                            <a rel=""nofollow""
                               id=""cancel-comment-reply-link""
                               href=""/discover-5-most-beautiful-towns-in-south-africa/#respond""
                               style=""display:none;"">Cancel reply</a>
                        </small>
                    </h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f648697a99382592884cda513e141cc89915509672", async() => {
                WriteLiteral(@"
                        <p class=""comment-notes"">
                            <span id=""email-notes"">Your email address will not be published.</span>
                            Required fields are marked <span class=""required"">*</span>
                        </p>
                        <p class=""comment-form-comment"">
                            <label for=""comment"">Comment</label>
                            <textarea id=""comment""
                                      name=""comment"" cols=""45"" rows=""8"" maxlength=""65525"" aria-required=""true""
                                      required=""required""></textarea>
                        </p>
                        <p class=""comment-form-author"">
                            <label for=""author"">Name <span class=""required"">*</span></label>
                            <input id=""author"" name=""author"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4768, "\"", 4776, 0);
                EndWriteAttribute();
                WriteLiteral(@" size=""30"" maxlength=""245""
                                   aria-required=""true"" required=""required"">
                        </p>
                        <p class=""comment-form-email"">
                            <label for=""email"">Email <span class=""required"">*</span></label>
                            <input id=""email"" name=""email"" type=""email""");
                BeginWriteAttribute("value", " value=\"", 5134, "\"", 5142, 0);
                EndWriteAttribute();
                WriteLiteral(@" size=""30"" maxlength=""100""
                                   aria-describedby=""email-notes"" aria-required=""true"" required=""required"">
                        </p>
                        <p class=""form-submit"">
                            <input name=""submit"" type=""submit"" id=""submit"" class=""submit""
                                   value=""Post Comment""> <input type=""hidden"" name=""comment_post_ID"" value=""239""
                                                                id=""comment_post_ID"">
                            <input type=""hidden"" name=""comment_parent"" id=""comment_parent"" value=""0"">
                        </p>
                        <p style=""display: none;"">
                            <input type=""hidden"" id=""akismet_comment_nonce""
                                   name=""akismet_comment_nonce"" value=""132a15c21c"">
                        </p>
                        <p style=""display: none;""></p>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <!-- #respond -->\r\n            </div>\r\n            <!-- #comments -->\r\n        </div>\r\n        ");
#nullable restore
#line 90 "C:\Users\ADMIN\source\repos\News\News\Views\News\News.cshtml"
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