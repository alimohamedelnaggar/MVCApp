#pragma checksum "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9a36baaccaff323156ef3b1844927cf9c10c5c4185e1fe24d4000acfe67dd345"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\_ViewImports.cshtml"
using Demo.Presentation

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\_ViewImports.cshtml"
using Demo.Presentation.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\_ViewImports.cshtml"
using Demo.DAL.Models

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\_ViewImports.cshtml"
using Demo.Presentation.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9a36baaccaff323156ef3b1844927cf9c10c5c4185e1fe24d4000acfe67dd345", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f2b7c436e081e2b756016b48a9e8fafe56362efca284043147cdc5de7e14ec85", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
       IEnumerable<UserViewModel>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n<h1>All Users</h1>\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a36baaccaff323156ef3b1844927cf9c10c5c4185e1fe24d4000acfe67dd3456892", async() => {
                WriteLiteral(@"
    <div class=""row"">

        <div class=""col-8"">
            <input type=""search"" class=""form-control"" name=""search"" id=""search"" />
        </div>
        <div class=""col-4"">
            <input type=""submit"" value=""search"" class=""btn btn-success"" />
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 25 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <table class=\"table table-striped table-responsive-sm table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
            Write(
#nullable restore
#line 30 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                     Html.DisplayNameFor(E => E.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th>");
            Write(
#nullable restore
#line 31 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                     Html.DisplayNameFor(E => E.FirstName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th>");
            Write(
#nullable restore
#line 32 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                     Html.DisplayNameFor(E => E.LastName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th>");
            Write(
#nullable restore
#line 33 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                     Html.DisplayNameFor(E => E.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th>");
            Write(
#nullable restore
#line 34 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                     Html.DisplayNameFor(E => E.Roles)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\r\n\r\n                    <td>");
            Write(
#nullable restore
#line 45 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                         user.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 46 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                         user.FirstName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 47 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                         user.LastName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 48 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                         user.Email

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 49 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                         string.Join(" \\ ",user.Roles)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a36baaccaff323156ef3b1844927cf9c10c5c4185e1fe24d4000acfe67dd34512695", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-eye\"></i> Details\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 52 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                                                               user.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a36baaccaff323156ef3b1844927cf9c10c5c4185e1fe24d4000acfe67dd34515183", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-edit\"></i> Update\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 57 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                                                            user.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a36baaccaff323156ef3b1844927cf9c10c5c4185e1fe24d4000acfe67dd34517668", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-trash\"></i> Delete\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 62 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
                                                              user.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 67 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 70 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"mt-4 alert alert-danger\"><h4>There is No Users :(</h4></div>\r\n");
#nullable restore
#line 74 "C:\Users\SoftLaptop\source\repos\Demo MVC ALi\Demo.Presentation\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<script>\r\n    \r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591