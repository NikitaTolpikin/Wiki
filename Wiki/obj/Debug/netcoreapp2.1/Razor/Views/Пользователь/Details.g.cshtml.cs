#pragma checksum "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a175ab1b8e363cbd6912cd1675f8d683a3f1e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Пользователь_Details), @"mvc.1.0.view", @"/Views/Пользователь/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Пользователь/Details.cshtml", typeof(AspNetCore.Views_Пользователь_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a175ab1b8e363cbd6912cd1675f8d683a3f1e1b", @"/Views/Пользователь/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a835dddb2f45780b0414433689c56bd0632b38", @"/Views/_ViewImports.cshtml")]
    public class Views_Пользователь_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wiki.Пользователь>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/_AdminMaster.cshtml";


#line default
#line hidden
            BeginContext(118, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Пользователь</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(245, 41, false);
#line 16 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(286, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(330, 37, false);
#line 19 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(411, 42, false);
#line 22 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Пароль));

#line default
#line hidden
            EndContext();
            BeginContext(453, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(497, 38, false);
#line 25 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.Пароль));

#line default
#line hidden
            EndContext();
            BeginContext(535, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(579, 48, false);
#line 28 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ДатаРождения));

#line default
#line hidden
            EndContext();
            BeginContext(627, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(671, 44, false);
#line 31 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.ДатаРождения));

#line default
#line hidden
            EndContext();
            BeginContext(715, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(759, 43, false);
#line 34 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Фамилия));

#line default
#line hidden
            EndContext();
            BeginContext(802, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(846, 39, false);
#line 37 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.Фамилия));

#line default
#line hidden
            EndContext();
            BeginContext(885, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(929, 39, false);
#line 40 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Имя));

#line default
#line hidden
            EndContext();
            BeginContext(968, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1012, 35, false);
#line 43 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.Имя));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1091, 44, false);
#line 46 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Отчество));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1179, 40, false);
#line 49 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.Отчество));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1263, 39, false);
#line 52 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Пол));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1346, 35, false);
#line 55 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.Пол));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1425, 51, false);
#line 58 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ДатаРегистрации));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1520, 47, false);
#line 61 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.ДатаРегистрации));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1611, 58, false);
#line 64 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.КодКатегорииNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1713, 63, false);
#line 67 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
       Write(Html.DisplayFor(model => model.КодКатегорииNavigation.Название));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1823, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbd0666540eb46dbbfd9c53804cf17a7", async() => {
                BeginContext(1881, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "D:\Projects\Wiki\Wiki\Views\Пользователь\Details.cshtml"
                           WriteLiteral(Model.IdПользователя);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1889, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1897, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed699b3f050b408e9ebaca789815f417", async() => {
                BeginContext(1919, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1935, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wiki.Пользователь> Html { get; private set; }
    }
}
#pragma warning restore 1591
