#pragma checksum "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a2a07bca5266dccd33d2b039748eb64c2ae4fef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_AllProjects), @"mvc.1.0.view", @"/Views/Project/AllProjects.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2a07bca5266dccd33d2b039748eb64c2ae4fef", @"/Views/Project/AllProjects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fbbc7c3b1f04fc4f60cb19a7e9b49ec054ea909", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_AllProjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SayItWebsiteNet5.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnSubscribeProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubscribeProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyProjects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
  
    ViewData["Title"] = "MyProjects";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 27 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a2a07bca5266dccd33d2b039748eb64c2ae4fef6943", async() => {
                WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 31 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                                                 WriteLiteral(item.Id.ToString());

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                </td>\n                <td>\n                    <p>\n");
#nullable restore
#line 35 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                          
                            if (item.Active)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Aktiv</span>\n");
#nullable restore
#line 39 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Inaktiv</span>\n");
#nullable restore
#line 43 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\n                </td>\n                <td>\n                    ");
#nullable restore
#line 48 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n\n");
#nullable restore
#line 52 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                     if (User?.Identity.IsAuthenticated ?? false)
                    {
                        if (item.Participants.Any(x => x._Id.ToString() == _userManager.GetUserId(User)))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a2a07bca5266dccd33d2b039748eb64c2ae4fef11416", async() => {
                WriteLiteral("Afmeld");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 57 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a2a07bca5266dccd33d2b039748eb64c2ae4fef14048", async() => {
                WriteLiteral("Tilmeld");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 61 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\n                            <span>Log p?? for tilmelde</span>\n                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2191, "\"", 2247, 3);
            WriteAttributeValue("", 2201, "location.href=\'", 2201, 15, true);
#nullable restore
#line 67 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
WriteAttributeValue("", 2216, Url.Action("Login","Account"), 2216, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2246, "\'", 2246, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Login</button>\n\n                        </div>\n");
#nullable restore
#line 70 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                     if (User?.Identity.IsAuthenticated ?? false)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                         if (User.IsInRole("Admin") || item.Owner._Id.ToString() == _userManager.GetUserId(User))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-danger\"> ");
#nullable restore
#line 75 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                                                  Write(Html.ValidationMessage("DeleteProjectError"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n                            <button class=\"btn btn-primary\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 2729, "\"", 2756, 1);
#nullable restore
#line 76 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
WriteAttributeValue("", 2737, item.Id.ToString(), 2737, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"myFunction(this)\">Slet</button>\n");
#nullable restore
#line 77 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 82 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a2a07bca5266dccd33d2b039748eb64c2ae4fef19964", async() => {
                WriteLiteral("Mine Projekter");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n<script>\n    function myFunction(obj) {\n        let text = \"??nsker du at slette projektet? \\n OK for at bekr??fte.\";\n        if (confirm(text) == true)\n            window.location.href = \'");
#nullable restore
#line 93 "C:\Users\Administrator\Downloads\SayIT-main\SayIT-main\SayItWebsiteNet5\Views\Project\AllProjects.cshtml"
                               Write(Url.Action("DeleteProject","Project"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\' + obj.value;\n\n    }\n</script>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SayItWebsiteNet5.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
