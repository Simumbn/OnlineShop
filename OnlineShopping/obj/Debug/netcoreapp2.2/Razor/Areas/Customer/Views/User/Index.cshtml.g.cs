#pragma checksum "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138eb797efa262d9455b50bdd94b8df0cef81e47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_User_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_User_Index))]
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
#line 1 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineShopping;

#line default
#line hidden
#line 1 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
using OnlineShopping.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138eb797efa262d9455b50bdd94b8df0cef81e47", @"/Areas/Customer/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1692c2495c9d4687dd5fa20601122c0273159d1f", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int i = 1;

#line default
#line hidden
            BeginContext(125, 164, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">User List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(289, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138eb797efa262d9455b50bdd94b8df0cef81e476067", async() => {
                BeginContext(333, 45, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp;Add New User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(382, 37, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<div>\r\n");
            EndContext();
            BeginContext(455, 560, true);
            WriteLiteral(@"    <table class=""table table-striped borderd"" id=""myTable"">
        <thead>
            <tr class=""table-info"">
                <th>
                    SL NO.
                </th>
                <th>
                    Name
                </th>
                <th>
                    UserName
                </th>
                <th>
                    Email
                </th>
                <th>Status</th>
                <th></th>
                <th></th>

            </tr>
        </thead>
        
        <tbody>
");
            EndContext();
#line 44 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1072, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1111, 1, false);
#line 47 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1140, 14, false);
#line 48 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1156, 13, false);
#line 48 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
                               Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1197, 13, false);
#line 49 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1210, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1238, 10, false);
#line 50 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1248, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 51 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
                 if (item.LockoutEnd > DateTime.Now && item.LockoutEnd != null)
                {

#line default
#line hidden
            BeginContext(1355, 142, true);
            WriteLiteral("                    <td>Inactive</td>\r\n                    <td>\r\n                        <div class=\"btn-group\">\r\n                            ");
            EndContext();
            BeginContext(1497, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138eb797efa262d9455b50bdd94b8df0cef81e4710832", async() => {
                BeginContext(1568, 91, true);
                WriteLiteral("\r\n                                <i class=\"far fa-edit\"></i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
                                                                             WriteLiteral(item.Id);

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
            BeginContext(1663, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1693, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138eb797efa262d9455b50bdd94b8df0cef81e4713404", async() => {
                BeginContext(1763, 96, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-trash-alt\"></i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
                                                                            WriteLiteral(item.Id);

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
            BeginContext(1863, 63, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </td>\r\n");
            EndContext();
#line 65 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1988, 107, true);
            WriteLiteral("                    <td>Active</td>\r\n                    <td style=\"width: 50px\">\r\n                        ");
            EndContext();
            BeginContext(2095, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "138eb797efa262d9455b50bdd94b8df0cef81e4716418", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 71 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2143, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 73 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(2193, 21, true);
            WriteLiteral("\r\n            </tr>\r\n");
            EndContext();
#line 77 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
                i++;
            }

#line default
#line hidden
            BeginContext(2251, 52, true);
            WriteLiteral("        </tbody>\r\n        \r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2320, 456, true);
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js""></script>

    <script type=""text/javascript"">

         $(document).ready( function () {
            $('#myTable').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        } );


        $(document).ready(function () {
            var Save = '");
                EndContext();
                BeginContext(2777, 16, false);
#line 100 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
                   Write(TempData["Save"]);

#line default
#line hidden
                EndContext();
                BeginContext(2793, 126, true);
                WriteLiteral("\'\r\n                if (Save != \'\') {\r\n                    alertify.success(Save);\r\n                }\r\n            var Edit = \'");
                EndContext();
                BeginContext(2920, 16, false);
#line 104 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
                   Write(TempData["Edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(2936, 130, true);
                WriteLiteral("\'\r\n                if (Edit != \'\') {\r\n                    alertify.warning(Edit);\r\n                }\r\n\r\n            var Delete = \'");
                EndContext();
                BeginContext(3067, 18, false);
#line 109 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\User\Index.cshtml"
                     Write(TempData["Delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(3085, 131, true);
                WriteLiteral("\'\r\n                if (Delete != \'\') {\r\n                    alertify.error(Delete);\r\n                }\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
