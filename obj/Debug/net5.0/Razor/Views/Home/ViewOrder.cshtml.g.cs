#pragma checksum "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae824a29c615628110a21e89a4d808da2806cd49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewOrder), @"mvc.1.0.view", @"/Views/Home/ViewOrder.cshtml")]
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
#line 1 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\_ViewImports.cshtml"
using MAQFurni;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\_ViewImports.cshtml"
using MAQFurni.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae824a29c615628110a21e89a4d808da2806cd49", @"/Views/Home/ViewOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af0d8d46e9810ccc2630830b39b78eaeba22be4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form-style"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
  
    var order = ViewBag.Order as Order;
    var shipping = ViewBag.ShippingInfo as ShippingInfo;
    string status = ViewBag.Status as string;
    string orderId = ViewBag.OrderId as string;
    string phone = ViewBag.Phone as string;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""row breadcrumb_box  align-items-center"">
                        <div class=""col-lg-6 col-md-6 col-sm-12 text-center text-md-left"">
                            <h2 class=""breadcrumb-title"">View Order</h2>
                        </div>
                        <div class=""col-lg-6  col-md-6 col-sm-12"">
                            <!-- breadcrumb-list start -->
                            <ul class=""breadcrumb-list text-center text-md-right"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"">View Order</li>
                            </ul>
                            <!-- breadcrumb-list end -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("\r\n    <!-- breadcrumb-area end -->\r\n\r\n    <!-- contact area start -->\r\n    <div class=\"contact-area pb-100px pt-100px\">\r\n        <div class=\"container\">\r\n            <div class=\"custom-row-2 row\">\r\n");
#nullable restore
#line 37 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                  if(order != null && shipping != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-5 col-md-5 mb-lm-60px col-sm-12 col-xs-12 w-sm-100"">
                       <div class=""contact-info-wrap"">
                        <h2 class=""title"" data-aos=""fade-up"" data-aos-delay=""200"">Order</h2>
                        <div class=""single-contact-info"" data-aos=""fade-up"" data-aos-delay=""200"">
                            <div class=""contact-info-inner"">
                                <span class=""sub-title"">Order ID: ");
#nullable restore
#line 43 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                                             Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""single-contact-info"" data-aos=""fade-up"" data-aos-delay=""200"">
                            <div class=""contact-info-inner"">
                                <span class=""sub-title"">Created Date: </span>
                            </div>
                            <div class=""contact-info-dec"">
                                <p><a> ");
#nullable restore
#line 51 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                  Write(order.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                            </div>
                        </div>
                        <div class=""single-contact-info"" data-aos=""fade-up"" data-aos-delay=""200"">
                            <div class=""contact-info-inner"">
                                <span class=""sub-title"">Address: </span>
                            </div>
                            <div class=""contact-info-dec"">
                                <p> ");
#nullable restore
#line 59 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                               Write(order.ShippingInfo.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 59 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                                            Write(order.ShippingInfo.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 59 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                                                                      Write(order.ShippingInfo.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""single-contact-info"" data-aos=""fade-up"" data-aos-delay=""200"">
                            <div class=""contact-info-inner"">
                                <span class=""sub-title"">Status: 
");
#nullable restore
#line 65 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                     if(shipping.StatusId == 1) {
                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                  Write(Html.Raw("Complete"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                                            ;
                                    }    
                                    else if(shipping.StatusId == 2) {
                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                  Write(Html.Raw("Pending"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                                           ;
                                    }  
                                    else if(shipping.StatusId == 3) {
                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                  Write(Html.Raw("Processing"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                                              ;
                                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </span>
                            </div>
                            <div class=""contact-info-dec"">
                                <p> </p>
                            </div>
                        </div>
                        <div class=""contact-social"">
                            <h3 class=""title"" data-aos=""fade-up"" data-aos-delay=""200"">Total Price: ");
#nullable restore
#line 81 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                                                                              Write(String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", order.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"social-info\" data-aos=\"fade-up\" data-aos-delay=\"200\">\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 104 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-7 col-md-7 col-sm-12 col-xs-12\">\r\n");
#nullable restore
#line 106 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                        if(status != null) {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                             if(status.Equals("")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span></span>\r\n");
#nullable restore
#line 109 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                        }
                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color: red; font-size: 14px;\">");
#nullable restore
#line 111 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                                                                  Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 112 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
                         
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""contact-form"">
                        <div class=""contact-title mb-30"">
                            <h2 class=""title"" data-aos=""fade-up"" data-aos-delay=""200"">View Order</h2>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae824a29c615628110a21e89a4d808da2806cd4914701", async() => {
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-12\" data-aos=\"fade-up\" data-aos-delay=\"200\">\r\n                                    <input");
                BeginWriteAttribute("value", " value=\"", 6544, "\"", 6560, 1);
#nullable restore
#line 121 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 6552, orderId, 6552, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required name=\"orderId\" placeholder=\"Order ID*\" type=\"text\" />\r\n                                </div>\r\n                                <div class=\"col-lg-12\" data-aos=\"fade-up\" data-aos-delay=\"200\">\r\n                                    <input");
                BeginWriteAttribute("value", " value=\"", 6805, "\"", 6819, 1);
#nullable restore
#line 124 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 6813, phone, 6813, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required name=""phone"" placeholder=""Mobile Phone*"" type=""text"" />
                                </div>
                                <button class=""btn btn-primary btn-hover-dark mt-4 ml-3"" data-aos=""fade-up"" data-aos-delay=""200"" type=""submit"">CHECK</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <p class=\"form-messege\"></p>\r\n                    </div>\r\n                </div>\r\n                <input type=\"hidden\" id=\"detail-add\">\r\n            </div>\r\n        </div>\r\n    </div>");
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
