#pragma checksum "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e60bebe3f9440ca9fd2233ba0a112bb2d6a6d81c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Правка_Details), @"mvc.1.0.view", @"/Views/Правка/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Правка/Details.cshtml", typeof(AspNetCore.Views_Правка_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60bebe3f9440ca9fd2233ba0a112bb2d6a6d81c", @"/Views/Правка/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a835dddb2f45780b0414433689c56bd0632b38", @"/Views/_ViewImports.cshtml")]
    public class Views_Правка_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wiki.Правка>
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
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/_AdminMaster.cshtml";

#line default
#line hidden
            BeginContext(110, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Правка</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(231, 48, false);
#line 15 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ДатаСоздания));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(323, 44, false);
#line 18 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.ДатаСоздания));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(411, 44, false);
#line 21 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Название));

#line default
#line hidden
            EndContext();
            BeginContext(455, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(499, 40, false);
#line 24 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.Название));

#line default
#line hidden
            EndContext();
            BeginContext(539, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(583, 47, false);
#line 27 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ТекстСтатьи));

#line default
#line hidden
            EndContext();
            BeginContext(630, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(674, 43, false);
#line 30 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.ТекстСтатьи));

#line default
#line hidden
            EndContext();
            BeginContext(717, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(761, 53, false);
#line 33 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ПутьДоИзображения));

#line default
#line hidden
            EndContext();
            BeginContext(814, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(858, 49, false);
#line 36 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.ПутьДоИзображения));

#line default
#line hidden
            EndContext();
            BeginContext(907, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(951, 47, false);
#line 39 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ПутьДоАудио));

#line default
#line hidden
            EndContext();
            BeginContext(998, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1042, 43, false);
#line 42 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.ПутьДоАудио));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1129, 56, false);
#line 45 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ДатаИзмененияСтатуса));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1229, 52, false);
#line 48 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.ДатаИзмененияСтатуса));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1325, 70, false);
#line 51 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdНазначенногоМодератораNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1439, 91, false);
#line 54 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdНазначенногоМодератораNavigation.IdНазначенногоМодератора));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1574, 60, false);
#line 57 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdПользователяNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1678, 62, false);
#line 60 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdПользователяNavigation.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1784, 54, false);
#line 63 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdСтатьиNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1882, 59, false);
#line 66 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdСтатьиNavigation.Название));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1985, 56, false);
#line 69 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.КодСтатусаNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2041, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2085, 61, false);
#line 72 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.КодСтатусаNavigation.Название));

#line default
#line hidden
            EndContext();
            BeginContext(2146, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2190, 58, false);
#line 75 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.КодЧастиРечиNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2292, 63, false);
#line 78 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
       Write(Html.DisplayFor(model => model.КодЧастиРечиNavigation.Название));

#line default
#line hidden
            EndContext();
            BeginContext(2355, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2402, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1272323759941a58e92bd2acd49c399", async() => {
                BeginContext(2454, 4, true);
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
#line 83 "D:\Projects\Wiki\Wiki\Views\Правка\Details.cshtml"
                           WriteLiteral(Model.IdПравки);

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
            BeginContext(2462, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2470, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6fed7f27d514124aff4f449ea14963c", async() => {
                BeginContext(2492, 12, true);
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
            BeginContext(2508, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wiki.Правка> Html { get; private set; }
    }
}
#pragma warning restore 1591
