#pragma checksum "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99388563d296a9a4c94efe9042d3494d7db41d36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Edit_Check), @"mvc.1.0.view", @"/Views/Edit/Check.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Edit/Check.cshtml", typeof(AspNetCore.Views_Edit_Check))]
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
#line 1 "D:\Projects\Wiki\Wiki\Views\_ViewImports.cshtml"
using Wiki;

#line default
#line hidden
#line 2 "D:\Projects\Wiki\Wiki\Views\_ViewImports.cshtml"
using Wiki.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99388563d296a9a4c94efe9042d3494d7db41d36", @"/Views/Edit/Check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a835dddb2f45780b0414433689c56bd0632b38", @"/Views/_ViewImports.cshtml")]
    public class Views_Edit_Check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wiki.ViewModels.EditCheckViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Check", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
  
    ViewData["Title"] = "Check";

#line default
#line hidden
            BeginContext(84, 348, true);
            WriteLiteral(@"
<div class=""row"" style=""min-height: 5vh""></div>
<div class=""row"">
    <div class=""col-md-1""></div>
    <div class=""col-md-10"">
        <div class=""row"">
            <div class=""col-md-3"">
                <h4>
                    Статус:
                </h4>
            </div>
            <div class=""col-md-3"">
                <h4>
");
            EndContext();
#line 18 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                     switch (Model.Правка.КодСтатуса)
                    {
                        case 0:

#line default
#line hidden
            BeginContext(543, 55, true);
            WriteLiteral("                            <span class=\"tag tag-info\">");
            EndContext();
            BeginContext(599, 42, false);
#line 21 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                  Write(Model.Правка.КодСтатусаNavigation.Название);

#line default
#line hidden
            EndContext();
            BeginContext(641, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 22 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                            break;
                        case 1:

#line default
#line hidden
            BeginContext(719, 58, true);
            WriteLiteral("                            <span class=\"tag tag-warning\">");
            EndContext();
            BeginContext(778, 42, false);
#line 24 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                     Write(Model.Правка.КодСтатусаNavigation.Название);

#line default
#line hidden
            EndContext();
            BeginContext(820, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 25 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                            break;
                        case 2:

#line default
#line hidden
            BeginContext(898, 58, true);
            WriteLiteral("                            <span class=\"tag tag-success\">");
            EndContext();
            BeginContext(957, 42, false);
#line 27 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                     Write(Model.Правка.КодСтатусаNavigation.Название);

#line default
#line hidden
            EndContext();
            BeginContext(999, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 28 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                            break;
                        case 3:

#line default
#line hidden
            BeginContext(1077, 57, true);
            WriteLiteral("                            <span class=\"tag tag-danger\">");
            EndContext();
            BeginContext(1135, 42, false);
#line 30 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                    Write(Model.Правка.КодСтатусаNavigation.Название);

#line default
#line hidden
            EndContext();
            BeginContext(1177, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 31 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                            break;
                    }

#line default
#line hidden
            BeginContext(1245, 296, true);
            WriteLiteral(@"                </h4>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3"">
                <h4>
                    Название:
                </h4>
            </div>
            <div class=""col-md-3"">
                <h4>
                    ");
            EndContext();
            BeginContext(1542, 21, false);
#line 44 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
               Write(Model.Правка.Название);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 221, true);
            WriteLiteral("\r\n                </h4>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\"><h4>Теги: </h4></div>\r\n            <div class=\"col-md-9 visible-md-inline\">\r\n                <h4>\r\n");
            EndContext();
#line 52 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                     foreach (var tag in Model.Правка.IdСтатьиNavigation.СловарнаяСтатьяТег)
                    {

#line default
#line hidden
            BeginContext(1901, 54, true);
            WriteLiteral("                        <span class=\"tag tag-default\">");
            EndContext();
            BeginContext(1956, 30, false);
#line 54 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                 Write(tag.КодТегаNavigation.Название);

#line default
#line hidden
            EndContext();
            BeginContext(1986, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 55 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                    }

#line default
#line hidden
            BeginContext(2018, 306, true);
            WriteLiteral(@"                </h4>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3"">
                <h4>
                    Часть речи:
                </h4>
            </div>
            <div class=""col-md-9"">
                <h4><span class=""tag tag-primary"">");
            EndContext();
            BeginContext(2325, 44, false);
#line 66 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                             Write(Model.Правка.КодЧастиРечиNavigation.Название);

#line default
#line hidden
            EndContext();
            BeginContext(2369, 168, true);
            WriteLiteral("</span></h4>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <p class=\"lead\">\r\n                    ");
            EndContext();
            BeginContext(2538, 24, false);
#line 72 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
               Write(Model.Правка.ТекстСтатьи);

#line default
#line hidden
            EndContext();
            BeginContext(2562, 99, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(2661, 552, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42e6c9981c3e4320ab5425c3b49e5d5f", async() => {
                BeginContext(2722, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2740, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61a430d94884418d91c51498469a82f7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 78 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdПравки);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 78 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                   WriteLiteral(Model.Правка.IdПравки);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2813, 133, true);
                WriteLiteral("\r\n                <div class=\"form-inline\">\r\n                    <div class=\"form-group pull-xs-right\">\r\n                            ");
                EndContext();
                BeginContext(2946, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94c381c6eed140b58fb05f038a4bb3d7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 81 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.КодСтатуса);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 81 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.allStatuses;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3037, 169, true);
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Сохранить\" class=\"btn btn-outline-primary\" />\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3213, 198, true);
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <h4>Комментарии</h4>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 94 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
             foreach (var comment in Model.ВсеКомментарии)
            {

#line default
#line hidden
            BeginContext(3486, 280, true);
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""card card-block"">
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <span>");
            EndContext();
            BeginContext(3767, 64, false);
#line 101 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                     Write(comment.IdПользователяNavigation.КодКатегорииNavigation.Название);

#line default
#line hidden
            EndContext();
            BeginContext(3831, 214, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"col-md-8\">\r\n                                    <div style=\"text-align: right\">\r\n                                        ");
            EndContext();
            BeginContext(4046, 22, false);
#line 105 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                   Write(comment.ВремяНаписания);

#line default
#line hidden
            EndContext();
            BeginContext(4068, 327, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <h4 class=""card-title"">
                                        ");
            EndContext();
            BeginContext(4396, 40, false);
#line 112 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                   Write(comment.IdПользователяNavigation.Фамилия);

#line default
#line hidden
            EndContext();
            BeginContext(4436, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4438, 36, false);
#line 112 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                                             Write(comment.IdПользователяNavigation.Имя);

#line default
#line hidden
            EndContext();
            BeginContext(4474, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4476, 41, false);
#line 112 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                                                                                   Write(comment.IdПользователяNavigation.Отчество);

#line default
#line hidden
            EndContext();
            BeginContext(4517, 324, true);
            WriteLiteral(@"
                                    </h4>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p class=""card-text"">
                                        ");
            EndContext();
            BeginContext(4842, 24, false);
#line 119 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                   Write(comment.ТекстКомментария);

#line default
#line hidden
            EndContext();
            BeginContext(4866, 204, true);
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 126 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
            }

#line default
#line hidden
            BeginContext(5085, 55, true);
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(5140, 609, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edb954d3e3e64a3ba80a9ee800f3723e", async() => {
                BeginContext(5202, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(5220, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "668520fdfc89425cbbcf7b1edd5fa51d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 130 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdПравки);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 130 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                   WriteLiteral(Model.Правка.IdПравки);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5293, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(5311, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c73f0c573d14f57a760e35b731efad2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 131 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ПредыдущийАдрес);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 131 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
                                                          WriteLiteral(Model.ПредыдущийАдрес);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5391, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(5409, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6356084e0b2548a5b046b603fe570549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 132 "D:\Projects\Wiki\Wiki\Views\Edit\Check.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ТекстКомментария);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5487, 255, true);
                WriteLiteral("\r\n                <div class=\"row\" style=\"min-height: 1vh\"></div>\r\n                <div class=\"pull-xs-right\">\r\n                    <input type=\"submit\" value=\"Отправить комментарий\" class=\"btn btn-outline-primary\" />\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5749, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-1\"></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wiki.ViewModels.EditCheckViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
