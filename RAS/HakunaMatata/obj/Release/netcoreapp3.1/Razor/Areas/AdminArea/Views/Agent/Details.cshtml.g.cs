#pragma checksum "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c749fe267b472532a0a5fa956c9a641f0c7827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Agent_Details), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Agent/Details.cshtml")]
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
#line 1 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using HakunaMatata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using HakunaMatata.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using HakunaMatata.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c749fe267b472532a0a5fa956c9a641f0c7827", @"/Areas/AdminArea/Views/Agent/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78366e9c7d2962e661ce2eb237f191be827e513e", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_Agent_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HakunaMatata.Models.ViewModels.VM_Agent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/img/a4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle circle-border m-b-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminArea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RealEstate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-white btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"wrapper wrapper-content animated fadeInRight\">\r\n    <div class=\"row m-b-lg m-t-lg\">\r\n        <div class=\"col-md-3\">\r\n\r\n            <div class=\"profile-image\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83c749fe267b472532a0a5fa956c9a641f0c78276763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"profile-info\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 409, "\"", 417, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div>\r\n                        <h2 class=\"no-margins\">\r\n                            ");
#nullable restore
#line 14 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h2>\r\n                        <h4><span><i class=\"fa fa-info mr-2\"></i></span> ");
#nullable restore
#line 16 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>\r\n                            ");
#nullable restore
#line 18 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                       Write(Model.ActivePosts);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 18 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                          Write(Model.TotalPosts);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" property active
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <table class=""table small"">
                <colgroup>
                    <col span=""1"" style=""width: 15%;"">
                    <col span=""1"" style=""width: 10%;"">
                    <col span=""1"" style=""width: 75%;"">
                </colgroup>
                <tbody>
                    <tr>
                        <td style=""border:none !important"">
                            Active
                        </td>
                        <td style=""border:none !important"">
                            <strong>");
#nullable restore
#line 37 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                               Write(Model.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </td>\r\n");
#nullable restore
#line 39 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                         if (Model.IsActive)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"border:none !important\"><a href=\"#\">Disable now</a></td>\r\n");
#nullable restore
#line 42 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tr>
                    <tr>
                        <td style=""border:none !important"">
                            Phone confirm
                        </td>
                        <td style=""border:none !important"">
                            <strong>");
#nullable restore
#line 49 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                               Write(Model.IsConfirmedNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"ibox\">\r\n");
#nullable restore
#line 60 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                 if (Model.Posts.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""ibox-title"">
                        <h5>All projects assigned to this account</h5>
                    </div>
                    <div class=""ibox-content"">

                        <div class=""project-list"">

                            <table class=""table table-hover"">
                                <thead>
                                    <tr>
                                        <th>Status</th>
                                        <th>Title</th>
                                        <th>Price</th>
                                        <th>Location</th>
                                        <th>Actions</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 80 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                     foreach (var item in Model.Posts)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n");
#nullable restore
#line 83 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                              
                                                var status = string.Empty;
                                                var statusClass = string.Empty;
                                                if (item.IsActive)
                                                {
                                                    status = item.ExprireTime < DateTime.Now ? "Sẵn sàng" : "Hết hạn";
                                                    statusClass = item.ExprireTime < DateTime.Now ? "label-primary" : "label-info";
                                                }
                                                else
                                                {
                                                    status = "Đã thuê";
                                                    statusClass = "label-default";
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"project-status\">\r\n                                                <span");
            BeginWriteAttribute("class", " class=\"", 4401, "\"", 4427, 2);
            WriteAttributeValue("", 4409, "label", 4409, 5, true);
#nullable restore
#line 98 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
WriteAttributeValue(" ", 4414, statusClass, 4415, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                                                            Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td class=\"project-title\">\r\n                                                <a href=\"project_detail.html\">");
#nullable restore
#line 101 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                                                         Write(item.RealEstateDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                <br />\r\n                                                <small>Created ");
#nullable restore
#line 103 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                                          Write(item.PostTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                            </td>\r\n                                            <td class=\"project-completion\">\r\n                                                ");
#nullable restore
#line 106 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                           Write(string.Format("{0:C}", item.RealEstateDetail.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </td>\r\n                                            <td class=\"project-title\">\r\n                                                ");
#nullable restore
#line 110 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                           Write(item.Map.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                            <td class=\"project-actions\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83c749fe267b472532a0a5fa956c9a641f0c782717459", async() => {
                WriteLiteral("\r\n                                                    <i class=\"fa fa-folder\"></i> View\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83c749fe267b472532a0a5fa956c9a641f0c782720299", async() => {
                WriteLiteral("\r\n                                                    <i class=\"fas fa-pencil\"></i> Edit\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 130 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 136 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"ibox-title\">\r\n\r\n                        <h5>Chưa có bài đăng nào</h5>\r\n                    </div>\r\n");
#nullable restore
#line 143 "D:\DUT\DATN\HakunaMatata\HakunaMatata\Areas\AdminArea\Views\Agent\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HakunaMatata.Models.ViewModels.VM_Agent> Html { get; private set; }
    }
}
#pragma warning restore 1591
