#pragma checksum "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45fb87a93d399a1d1ac2204d4a7a4b9df0464ac0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Permission_List), @"mvc.1.0.view", @"/Areas/Manager/Views/Permission/List.cshtml")]
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
#line 2 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using HumanIK.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using HumanIK.ENTITIES.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using HumanIK.ENTITIES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using HumanIK.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using HumanIK.BUSINESS.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using HumanIK.ENTITIES.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using FormHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45fb87a93d399a1d1ac2204d4a7a4b9df0464ac0", @"/Areas/Manager/Views/Permission/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f17cf5752d1be53c22f5cee26e20ba5192f83f", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Permission_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HumanIK.ENTITIES.Entities.Permission>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Reddet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Refuse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
  
    ViewData["Title"] = "İzin Talepleri";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex header-sticky\">\r\n    <h1 class=\"d-inline ml-0\">Harcama Talepleri</h1>\r\n");
            WriteLiteral(@"</div>
<div class=""container-fluid overflow-auto align-self-lg-start tableFixHead"">
    <!-- tableFixHead tablo başlıklarını sayfaya sabitler-->
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>
                    ");
#nullable restore
#line 18 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
               Write(Html.DisplayNameFor(model => model.DemandOwner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
               Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
               Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
               Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfReply));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"text-center\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
               Write(Html.DisplayNameFor(model => model.ConfirmationStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
            WriteLiteral("                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                   Write(item.DemandOwner?.GetFullNameShort().ToTitleCase());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateOfReply));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n");
#nullable restore
#line 70 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                         if (Convert.ToInt32(item.ConfirmationStatus) == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"mdi mdi-circle status-active\"></i>\r\n");
#nullable restore
#line 73 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                        }
                        else if (Convert.ToInt32(item.ConfirmationStatus) == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"mdi mdi-circle status-passive\"></i>\r\n");
#nullable restore
#line 77 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"mdi mdi-circle status-pending\"></i>\r\n");
#nullable restore
#line 81 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n");
            WriteLiteral("                    <td class=\"text-center\">\r\n");
#nullable restore
#line 99 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                         if (item.ConfirmationStatus == ConfirmationStatus.Pending)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-outline-info\" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"Onayla\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4352, "\"", 4389, 3);
            WriteAttributeValue("", 4362, "confirmPermission(", 4362, 18, true);
#nullable restore
#line 101 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
WriteAttributeValue("", 4380, item.ID, 4380, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4388, ")", 4388, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"mdi mdi-check-bold\"></i>\r\n                            </a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45fb87a93d399a1d1ac2204d4a7a4b9df0464ac014183", async() => {
                WriteLiteral("\r\n                                <i class=\"mdi mdi-close\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                                                                                                                                                 WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                                                                                                                                                                                  WriteLiteral(item.DemandOwner.GetFullName());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["demandOwner"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-demandOwner", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["demandOwner"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 107 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 111 "C:\Users\aa\source\Workspaces\İKProje\HumanIK\HumanIK.UI\Areas\Manager\Views\Permission\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HumanIK.ENTITIES.Entities.Permission>> Html { get; private set; }
    }
}
#pragma warning restore 1591