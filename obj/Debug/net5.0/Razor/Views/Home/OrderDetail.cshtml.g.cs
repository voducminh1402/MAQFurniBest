#pragma checksum "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b99a360a7366366e2585d8445ac25896dc120f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderDetail), @"mvc.1.0.view", @"/Views/Home/OrderDetail.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\_ViewImports.cshtml"
using MAQFurni;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\_ViewImports.cshtml"
using MAQFurni.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b99a360a7366366e2585d8445ac25896dc120f8", @"/Views/Home/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af0d8d46e9810ccc2630830b39b78eaeba22be4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- breadcrumb-area start -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row breadcrumb_box  align-items-center"">
                    <div class=""col-lg-6 col-md-6 col-sm-12 text-center text-md-left"">
                        <h2 class=""breadcrumb-title"">Shop</h2>
                    </div>
                    <div class=""col-lg-6  col-md-6 col-sm-12"">
                        <!-- breadcrumb-list start -->
                        <ul class=""breadcrumb-list text-center text-md-right"">
                            <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b99a360a7366366e2585d8445ac25896dc120f84651", async() => {
                WriteLiteral("Orders History");
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
            WriteLiteral(@"</li>
                            <li class=""breadcrumb-item active"">Order Details</li>
                        </ul>
                        <!-- breadcrumb-list end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- breadcrumb-area end -->

<!-- Wishlist Area Start -->
<div class=""cart-main-area pt-100px pb-100px"">
    <div class=""container"">
        <span class=""cart-page-title"">Order ID: </span><span>");
#nullable restore
#line 30 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml"
                                                        Write(ViewBag.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        \r\n        <div class=\"row mt-5\">\r\n            <div class=\"col-lg-12 col-md-12 col-sm-12 col-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b99a360a7366366e2585d8445ac25896dc120f86709", async() => {
                WriteLiteral(@"
                    <div class=""table-content table-responsive cart-table-content"">
                        <table>
                            <thead>
                                <tr>
                                    <th>Image</th>
                                    <th>Product Name</th>
                                    <th>Until Price</th>
                                    <th>Qty</th>
                                    <th>Subtotal</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 47 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml"
                                   var list = ViewBag.OrderDetails;
                                    foreach (var item in list)
                                {
                                    
                                
                                    decimal price = item.DetailPrice * item.Quantity;
                                
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td class=\"product-thumbnail\">\r\n                                        <a href=\"#\"><img class=\"img-responsive ml-3\"");
                BeginWriteAttribute("src", "\r\n                                                src=\"", 2525, "\"", 2606, 1);
#nullable restore
#line 58 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml"
WriteAttributeValue("", 2580, item.Product.ProductImage, 2580, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2607, "\"", 2613, 0);
                EndWriteAttribute();
                WriteLiteral(" /></a>\r\n                                    </td>\r\n                                    <td class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 60 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml"
                                                                    Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                    \r\n                                    <td class=\"product-price-cart\"><span class=\"amount\">");
#nullable restore
#line 62 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml"
                                                                                   Write(String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", item.DetailPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                                    <td class=\"product-quantity\">\r\n                                        <span class=\"amount\">");
#nullable restore
#line 64 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml"
                                                        Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </td>\r\n                                    <td class=\"product-subtotal\">");
#nullable restore
#line 66 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml"
                                                            Write(String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    \r\n                                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Views\Home\OrderDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                \r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- Wishlist Area End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
