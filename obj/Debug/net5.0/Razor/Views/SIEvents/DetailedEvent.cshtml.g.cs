#pragma checksum "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f391c30ebe442890f49e0e5c5f251d94b6dee53f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SIEvents_DetailedEvent), @"mvc.1.0.view", @"/Views/SIEvents/DetailedEvent.cshtml")]
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
#line 1 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\_ViewImports.cshtml"
using SayItWebsiteNet5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\_ViewImports.cshtml"
using SayItWebsiteNet5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\_ViewImports.cshtml"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f391c30ebe442890f49e0e5c5f251d94b6dee53f", @"/Views/SIEvents/DetailedEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fbbc7c3b1f04fc4f60cb19a7e9b49ec054ea909", @"/Views/_ViewImports.cshtml")]
    public class Views_SIEvents_DetailedEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SayItWebsiteNet5.Models.SIEvents>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
  
    ViewData["Title"] = "Event Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Event Information</h1>\n\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 13 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 16 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 19 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 22 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 25 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 28 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 31 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 34 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 37 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Creator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n       \n                <p> ");
#nullable restore
#line 41 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
               Write(ViewBag.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n          \n\n        </dd>\n    </dl>\n</div>\n<div>\n    <table>\n        <thead>\n            <tr>\n                <th>\n                    <p>Deltagere</p>\n                </th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 57 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
             foreach (var person in Model.Participants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 61 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
                   Write(Html.DisplayFor(modelItem => person.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
                                                              Write(Html.DisplayFor(modelItem => person.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 64 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n</div>\n\n<div>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f391c30ebe442890f49e0e5c5f251d94b6dee53f9018", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SayItWebsiteNet5.Models.SIEvents> Html { get; private set; }
    }
}
#pragma warning restore 1591
