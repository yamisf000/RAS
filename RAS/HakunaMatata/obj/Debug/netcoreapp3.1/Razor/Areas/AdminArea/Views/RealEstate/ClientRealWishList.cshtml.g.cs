#pragma checksum "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b8b26fdb87718cc240e83c82a9425734d4c6519"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_RealEstate_ClientRealWishList), @"mvc.1.0.view", @"/Areas/AdminArea/Views/RealEstate/ClientRealWishList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8b26fdb87718cc240e83c82a9425734d4c6519", @"/Areas/AdminArea/Views/RealEstate/ClientRealWishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cad70836f9b0457d0b3cc3c17ec308c911ac87", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminArea_Views_RealEstate_ClientRealWishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HakunaMatata.Models.ViewModels.VM_WishList>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/maplace-active.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
  
    ViewData["Title"] = "Trang chủ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script async defer\r\n            src=\"https://maps.googleapis.com/maps/api/js?key=MY_API_KEY&callback=LoadMarker\">\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b8b26fdb87718cc240e83c82a9425734d4c65195964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<!-- user wish -->\r\n<div>\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 17 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"wish-item row\">\r\n                <div class=\"col-4\">\r\n");
#nullable restore
#line 21 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
                      
                        string imagePath = $"/images/{item.Url}";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img class=\"img-item-wish\" style=\"width: 70%;\"");
            BeginWriteAttribute("src", " src=\"", 710, "\"", 726, 1);
#nullable restore
#line 24 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
WriteAttributeValue("", 716, imagePath, 716, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-8\">\r\n                    <h3 style=\"color:black\" class=\"title-wish-item\">");
#nullable restore
#line 27 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"row\">\r\n                        <p class=\"col-2 wish-address\">Address : </p>\r\n                        <p class=\"col-10 wish-address-data\">");
#nullable restore
#line 30 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
                                                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <p class=\"col-2 wish-cost\">Cost : </p>\r\n                        <p class=\"col-10 wish-cost-data\">");
#nullable restore
#line 34 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b8b26fdb87718cc240e83c82a9425734d4c651910027", async() => {
                WriteLiteral(@"
                        <div class=""col-xl-4 col-lg-6 col-md-6 btn-container"">
                            <input style=""color: red; border: 2px solid"" class=""btn btn-buy"" type=""submit"" value=""REMOVE"" />
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1334, "/wish-list/", 1334, 11, true);
#nullable restore
#line 36 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
AddHtmlAttributeValue("", 1345, item.Id, 1345, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\Users\nolif\OneDrive\Desktop\RAS_final1\RAS_final\RAS\HakunaMatata\Areas\AdminArea\Views\RealEstate\ClientRealWishList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

</div>
<!-- user wish end -->

<style>
    .container-text {
        padding-bottom: 20px;
    }

    .name-news {
        padding-top: 12px;
    }

    .container-title-text {
        margin-bottom: 70px;
    }

    .img-item-wish {
        height: 100%;
    }

    .user-wishlist,
    .user-search {
        display: flex;
    }

    .user-search {
        margin: 40px 0;
    }

    .img-user {
        width: 48px;
        height: 48px;
        margin-right: 16px;
    }

    .search-input {
        width: 100%;
        border: none;
        outline: none;
        font-size: 14px;
        padding: 0 16px;
        border-radius: 2px;
        background-color: #ebeef3;
    }

    .search-btn {
        background-color: #000;
        border: none;
        border-radius: 2px;
        margin-right: 3px;
        height: 34px;
        width: 60px;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .sear");
            WriteLiteral(@"ch-btn-icon {
        font-size: 14px;
        color: #fff;
    }

    .wish-item {
        background-color: #ebeef3;
        padding: 16px 0;
        margin-bottom: 16px;
    }

    .wish-address,
    .wish-cost {
        font-weight: bold;
        color: #000;
    }

    .wish-address-data,
    .wish-cost-data,
    .remove-item-wish {
        color: #000;
    }

    .remove-item-wish {
        background-color: #fff;
        border-radius: 12px;
        width: 100px;
        padding: 0 12px;
    }
</style>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HakunaMatata.Models.ViewModels.VM_WishList>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
