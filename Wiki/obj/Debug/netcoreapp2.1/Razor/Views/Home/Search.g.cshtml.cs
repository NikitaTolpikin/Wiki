#pragma checksum "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a1a71532bb49a9a660accc707132445093e9cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Search.cshtml", typeof(AspNetCore.Views_Home_Search))]
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
#line 1 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\_ViewImports.cshtml"
using Wiki;

#line default
#line hidden
#line 2 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\_ViewImports.cshtml"
using Wiki.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a1a71532bb49a9a660accc707132445093e9cb6", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a835dddb2f45780b0414433689c56bd0632b38", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Wiki.СловарнаяСтатья>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Поиск по " + ViewData["searchString"];


#line default
#line hidden
            BeginContext(118, 176, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"min-height: 5vh\"></div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-1\"></div>\r\n    <div class=\"col-md-10\">\r\n        <h2>\r\n            Статьи по слову \"");
            EndContext();
            BeginContext(295, 24, false);
#line 13 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                        Write(ViewData["searchString"]);

#line default
#line hidden
            EndContext();
            BeginContext(319, 18, true);
            WriteLiteral("\"\r\n        </h2>\r\n");
            EndContext();
#line 15 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(381, 40, true);
            WriteLiteral("            <ul class=\"list-unstyled\">\r\n");
            EndContext();
#line 18 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(486, 40, true);
            WriteLiteral("                <li class=\"list-item\">\r\n");
            EndContext();
#line 21 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                     if (item.СтатьяГотова)
                    {

#line default
#line hidden
            BeginContext(594, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(618, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be65cc61cf8b48d68087e8ce24cdeedf", async() => {
                BeginContext(704, 13, false);
#line 23 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                                                                                                        Write(item.Название);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-article_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                                                                                 WriteLiteral(item.IdСтатьи);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["article_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-article_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["article_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(721, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(795, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(819, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7477205240461ba471241926d45c74", async() => {
                BeginContext(924, 13, false);
#line 27 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                                                                                                                           Write(item.Название);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-article_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                                                                                                    WriteLiteral(item.IdСтатьи);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["article_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-article_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["article_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(941, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                    }

#line default
#line hidden
            BeginContext(966, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 29 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                     foreach (var tag in item.СловарнаяСтатьяТег)
                    {

#line default
#line hidden
            BeginContext(1056, 54, true);
            WriteLiteral("                        <span class=\"tag tag-default\">");
            EndContext();
            BeginContext(1111, 30, false);
#line 31 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                                                 Write(tag.КодТегаNavigation.Название);

#line default
#line hidden
            EndContext();
            BeginContext(1141, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 32 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                    }

#line default
#line hidden
            BeginContext(1173, 23, true);
            WriteLiteral("                </li>\r\n");
            EndContext();
#line 34 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                }

#line default
#line hidden
            BeginContext(1215, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 36 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1270, 52, true);
            WriteLiteral("            <p>Соответствий запросу не найдено</p>\r\n");
            EndContext();
#line 40 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
        }

#line default
#line hidden
            BeginContext(1333, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1341, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "445f880efcd04b8eba90fca9fb96c668", async() => {
                BeginContext(1429, 18, true);
                WriteLiteral("[Добавить статью \"");
                EndContext();
                BeginContext(1448, 24, false);
#line 41 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                                                                                                             Write(ViewData["searchString"]);

#line default
#line hidden
                EndContext();
                BeginContext(1472, 2, true);
                WriteLiteral("\"]");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\georg\Desktop\Бизнес-курсы\Управление данными\Wiki\Wiki\Views\Home\Search.cshtml"
                                                         WriteLiteral(ViewData["searchString"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1478, 56, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-1\"></div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Wiki.СловарнаяСтатья>> Html { get; private set; }
    }
}
#pragma warning restore 1591
