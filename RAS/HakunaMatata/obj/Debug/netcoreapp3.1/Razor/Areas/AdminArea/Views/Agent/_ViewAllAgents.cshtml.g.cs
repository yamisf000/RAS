#pragma checksum "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd873159c619817236d9b7a10889f046d4ee76fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Agent__ViewAllAgents), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Agent/_ViewAllAgents.cshtml")]
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
#line 1 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using HakunaMatata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using HakunaMatata.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\_ViewImports.cshtml"
using HakunaMatata.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd873159c619817236d9b7a10889f046d4ee76fd", @"/Areas/AdminArea/Views/Agent/_ViewAllAgents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cad70836f9b0457d0b3cc3c17ec308c911ac87", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminArea_Views_Agent__ViewAllAgents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HakunaMatata.Models.DataModels.Agent>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminArea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Disable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return DisableAgent(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return DeleteAgent(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
  
    int index = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Danh sách các thành viên</h5>
                </div>
                <div class=""ibox-content"">
");
            WriteLiteral(@"                    <table class=""table table-hover table-bordered"">
                        <thead>
                            <tr>
                                <th class=""text-center"">#</th>
                                <th class=""text-center"">
                                    Họ và tên
                                </th>
                                <th class=""text-center"">
                                    Trạng thái
                                </th>
                                <th class=""text-center"">
                                    Số điện thoại
                                </th>
");
            WriteLiteral(@"                                <th class=""text-center"">
                                    Chức vụ
                                </th>
                                <th class=""text-center"">Thao tác</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 42 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"text-center\">\n");
#nullable restore
#line 45 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                                      
                                        var status = item.IsActive ? "Active" : "Disabled";
                                        var statusClass = item.IsActive ? "label-success" : "";

                                        var confirmPhone = item.ConfirmPhoneNumber ? "Đã xác nhận" : "Chưa xác nhận";
                                        var confirmPhoneClass = item.ConfirmPhoneNumber ? "label-success" : "";

                                        string roleClass = string.Empty;
                                        switch (item.LevelId)
                                        {
                                            case 1:
                                                roleClass = "label-success";
                                                break;
                                            case 2: roleClass = "label-info"; break;
                                            default: roleClass = "label-primary"; break;
                                        }
                                        
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 63 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                                    Write(index++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n                                        ");
#nullable restore
#line 65 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                                   Write(item.AgentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n                                    <td><span");
            BeginWriteAttribute("class", " class=\"", 3278, "\"", 3304, 2);
            WriteAttributeValue("", 3286, "label", 3286, 5, true);
#nullable restore
#line 67 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
WriteAttributeValue(" ", 3291, statusClass, 3292, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                                                                    Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n\n                                    <td>");
#nullable restore
#line 69 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                                   Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
            WriteLiteral("\n                                    <td><span");
            BeginWriteAttribute("class", " class=\"", 3546, "\"", 3570, 2);
            WriteAttributeValue("", 3554, "label", 3554, 5, true);
#nullable restore
#line 73 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
WriteAttributeValue(" ", 3559, roleClass, 3560, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                                                                  Write(item.Level.LevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n\n                                    <td class=\"text-center\">\n");
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd873159c619817236d9b7a10889f046d4ee76fd12760", async() => {
                WriteLiteral(@"
                                            <button class=""btn btn-warning btn-circle"" title=""Khóa"" type=""submit"">
                                                <i class=""fas fa-user-lock""></i>
                                            </button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd873159c619817236d9b7a10889f046d4ee76fd16194", async() => {
                WriteLiteral(@"
                                            <button class=""btn btn-danger btn-circle"" title=""Xóa tài khoản"" type=""submit"">
                                                <i class=""fas fa-times""></i>
                                            </button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 94 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\Agent\_ViewAllAgents.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n\n                </div>\n            </div>\n        </div>\n    </div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HakunaMatata.Models.DataModels.Agent>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
