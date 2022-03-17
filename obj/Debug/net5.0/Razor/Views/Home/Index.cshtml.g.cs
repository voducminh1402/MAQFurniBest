#pragma checksum "D:\MAQFurniBest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f3c686704abd7c81a7677817012002e5a33de47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\MAQFurniBest\Views\_ViewImports.cshtml"
using MAQFurni;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MAQFurniBest\Views\_ViewImports.cshtml"
using MAQFurni.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3c686704abd7c81a7677817012002e5a33de47", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af0d8d46e9810ccc2630830b39b78eaeba22be4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <!-- Hero/Intro Slider Start -->
    <div class=""section "">
        <div class=""hero-slider swiper-container slider-nav-style-1 slider-dot-style-1"">
            <!-- Hero slider Active -->
            <div class=""swiper-wrapper"">
                <!-- Single slider item -->
                <div class=""hero-slide-item slider-height swiper-slide d-flex"">
                    <div class=""container align-self-center"">
                        <div class=""row"">
                            <div class=""col-xl-6 col-lg-7 col-md-7 col-sm-7 align-self-center"">
                                <div class=""hero-slide-content slider-animated-1"">
                                    <span class=""category"">New Products</span>
                                    <h2 class=""title-1"">Flexible Chair </h2>
                                    <p>The eco-sofa is an adaptable piece of art, which can be extended into a 12 seat bench or compacted down into a seat chair.</p>
                                    <a href=""http");
            WriteLiteral(@"s://localhost:5001/Home/Shopping"" class=""btn btn-lg btn-primary btn-hover-dark mt-5"">Shop Now</a>
                                </div>
                            </div>
                            <div class=""col-xl-6 col-lg-5 col-md-5 col-sm-5"">
                                <div class=""hero-slide-image"">
                                    <img src=""https://www.ignant.com/wp-content/uploads/2016/11/FlexibleLove_Chishen-Chiu_03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1496, "\"", 1502, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Single slider item -->
                <div class=""hero-slide-item slider-height swiper-slide d-flex"">
                    <div class=""container align-self-center"">
                        <div class=""row"">
                            <div class=""col-xl-6 col-lg-7 col-md-7 col-sm-7 align-self-center"">
                                <div class=""hero-slide-content slider-animated-1"">
                                    <span class=""category"">New Products</span>
                                    <h2 class=""title-1"">Flexible Table </h2>
                                    <p>This unique practical table is ideal for those who have guests from time to time and need to accomodate them.</p>
                                    <a href=""https://localhost:5001/Home/Shopping"" class=""btn btn-lg btn-primary btn-hover-dark mt-5"">");
            WriteLiteral(@"Shop Now</a>
                                </div>
                            </div>
                            <div class=""col-xl-6 col-lg-5 col-md-5 col-sm-5"">
                                <div class=""hero-slide-image"">
                                    <img src=""https://www.digsdigs.com/photos/2018/02/01-This-unique-practical-table-is-ideal-for-those-who-have-guests-from-time-to-time-and-need-to-accomodate-them-775x496.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2970, "\"", 2976, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Add Pagination -->
            <div class=""swiper-pagination swiper-pagination-white""></div>
            <!-- Add Arrows -->
            <div class=""swiper-buttons"">
                <div class=""swiper-button-next""></div>
                <div class=""swiper-button-prev""></div>
            </div>
        </div>
    </div>

    <!-- Hero/Intro Slider End -->

    <!-- Product Category Start -->
    <div class=""section pt-100px pb-100px"">
            <div class=""container"">
                <div class=""category-slider swiper-container"" data-aos=""fade-up"">
                    <div class=""category-wrapper swiper-wrapper"">
");
#nullable restore
#line 65 "D:\MAQFurniBest\Views\Home\Index.cshtml"
                             foreach (var item in Model.ListCategory)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\" swiper-slide\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4019, "\"", 4104, 2);
            WriteAttributeValue("", 4026, "/Home/FilterCategory?categoryId=", 4026, 32, true);
#nullable restore
#line 68 "D:\MAQFurniBest\Views\Home\Index.cshtml"
WriteAttributeValue("", 4058, Html.DisplayFor(modelItem => item.CategoryId), 4058, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"category-inner \">\r\n                                        <div class=\"category-single-item\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 4256, "\"", 4311, 1);
#nullable restore
#line 70 "D:\MAQFurniBest\Views\Home\Index.cshtml"
WriteAttributeValue("", 4262, Html.DisplayFor(modelItem => item.CategoryImage), 4262, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4312, "\"", 4318, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <span class=\"title\">");
#nullable restore
#line 71 "D:\MAQFurniBest\Views\Home\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </a>\r\n                                </div>\r\n");
#nullable restore
#line 75 "D:\MAQFurniBest\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>

    <!-- Product Category End -->

    <!-- Product tab Area Start -->
    <div class=""section product-tab-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 text-center"" data-aos=""fade-up"">
                    <div class=""section-title mb-0"">
                        <h2 class=""title"">Our Products</h2>
                        <p class=""sub-title mb-6"">Torem ipsum dolor sit amet, consectetur adipisicing elitsed do eiusmo tempor incididunt ut labore</p>
                    </div>
                </div>

                <!-- Tab Start -->
                <div class=""col-md-12 text-center mb-8"" data-aos=""fade-up"" data-aos-delay=""200"">
                    <ul class=""product-tab-nav nav justify-content-center"">
                        <li class=""nav-item""><a class=""nav-link active"" data-bs-toggle=""tab"" href=""#tab-product-new-arrivals"">New Arrivals</a></li>");
            WriteLiteral(@"
                        <li class=""nav-item""><a class=""nav-link"" data-bs-toggle=""tab"" href=""#tab-product-best-sellers"">Best
                                Sellers </a></li>
                        <li class=""nav-item""><a class=""nav-link"" data-bs-toggle=""tab"" href=""#tab-product-sale-item"">Sale
                                Items</a></li>
                        <li class=""nav-item""><a class=""nav-link"" data-bs-toggle=""tab"" href=""#tab-product-on-sales"">On
                                Sales</a></li>
                    </ul>
                </div>
                <!-- Tab End -->
            </div>
            <div class=""row"">
                <div class=""col"">
                    <div class=""tab-content"">
                        <!-- 1st tab start -->
                        <div class=""tab-pane fade show active"" id=""tab-product-new-arrivals"">
                            <div class=""row"">
");
#nullable restore
#line 271 "D:\MAQFurniBest\Views\Home\Index.cshtml"
                                 foreach (var item in Model.ListProduct)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                     <div class=""col-lg-3 col-md-6 col-sm-6 col-xs-6  mb-md-30px mb-lm-30px"" data-aos=""fade-up"" data-aos-delay=""400"">
                                    <!-- Single Prodect -->
                                    <div class=""product"">
                                        <div class=""thumb"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 19688, "\"", 19740, 2);
            WriteAttributeValue("", 19695, "/Home/DetailProduct?productId=", 19695, 30, true);
#nullable restore
#line 277 "D:\MAQFurniBest\Views\Home\Index.cshtml"
WriteAttributeValue("", 19725, item.ProductId, 19725, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 19810, "\"", 19864, 1);
#nullable restore
#line 278 "D:\MAQFurniBest\Views\Home\Index.cshtml"
WriteAttributeValue("", 19816, Html.DisplayFor(modelItem => item.ProductImage), 19816, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Product"" />
                                            </a>
                                            <span class=""badges"">
                                                
                                            </span>
                                            <div class=""actions"">
                                                <a href=""wishlist.html"" class=""action wishlist"" title=""Wishlist""><i
                                                        class=""icon-heart""></i></a>
                                                <a href=""#"" class=""action quickview"" data-link-action=""quickview"" title=""Quick view"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal""><i
                                                        class=""icon-size-fullscreen""></i></a>
                                                <a href=""compare.html"" class=""action compare"" title=""Compare""><i
                                                        class=""icon-refresh""></i></a>
                             ");
            WriteLiteral(@"               </div>
                                            <button title=""Add To Cart"" class=""add-to-cart"">Add
                                                To Cart
                                                <input id=""pCartImage"" type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 21150, "\"", 21206, 1);
#nullable restore
#line 293 "D:\MAQFurniBest\Views\Home\Index.cshtml"
WriteAttributeValue("", 21158, Html.DisplayFor(modelItem => item.ProductImage), 21158, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <input id=\"pCartId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 21293, "\"", 21346, 1);
#nullable restore
#line 294 "D:\MAQFurniBest\Views\Home\Index.cshtml"
WriteAttributeValue("", 21301, Html.DisplayFor(modelItem => item.ProductId), 21301, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <input id=\"pCartName\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 21435, "\"", 21490, 1);
#nullable restore
#line 295 "D:\MAQFurniBest\Views\Home\Index.cshtml"
WriteAttributeValue("", 21443, Html.DisplayFor(modelItem => item.ProductName), 21443, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <input id=\"pCartPrice\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 21580, "\"", 21636, 1);
#nullable restore
#line 296 "D:\MAQFurniBest\Views\Home\Index.cshtml"
WriteAttributeValue("", 21588, Html.DisplayFor(modelItem => item.ProductPrice), 21588, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                </button>
                                        </div>
                                        <div class=""content"">
                                            <h5 class=""title""><a href=""shop-left-sidebar.html"">");
#nullable restore
#line 300 "D:\MAQFurniBest\Views\Home\Index.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                            <span class=\"price\">\r\n                                                <span class=\"new\">");
#nullable restore
#line 302 "D:\MAQFurniBest\Views\Home\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.ProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND</span>
                                            </span>
                                        </div>
                                    </div>
                                    <input id=""detail-add"" type=""hidden"">
                                    <!-- Single Prodect -->
                                </div>
");
#nullable restore
#line 309 "D:\MAQFurniBest\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <!-- 4th tab end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Product tab Area End -->

    <!-- Banner Section Start -->
    <div class=""section pb-100px pt-100px"">
        <div class=""container"">
            <!-- Banners Start -->
            <div class=""row"">
                <!-- Banner Start -->
                <div class=""col-lg-6 col-12 mb-md-30px mb-lm-30px"" data-aos=""fade-up"" data-aos-delay=""200"">
                    <a href=""https://localhost:5001/Home/Shopping"" class=""banner"">
                        <img src=""https://www.seasons-spa.com/wp-content/uploads/fly-images/12226/restoran-570x290-.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 88724, "\"", 88730, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"info justify-content-end\">\r\n");
            WriteLiteral(@"                        </div>
                    </a>
                </div>
                <!-- Banner End -->

                <!-- Banner Start -->
                <div class=""col-lg-6 col-12"" data-aos=""fade-up"" data-aos-delay=""400"">
                    <a href=""https://localhost:5001/Home/Shopping"" class=""banner"">
                        <img src=""https://www.seasons-spa.com/wp-content/uploads/fly-images/12235/vip_gostinaya-570x290-.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 89581, "\"", 89587, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"info justify-content-start\">\r\n");
            WriteLiteral(@"                        </div>
                    </a>
                </div>
                <!-- Banner End -->
            </div>
            <!-- Banners End -->
        </div>
    </div>
    <!-- Banner Section End -->
    <!--  Blog area Start -->
");
            WriteLiteral(@"    <!--  Blog area End -->

    <!-- Instagram Area Start -->
    <div class=""section pb-100px"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"" data-aos=""fade-up"">
                    <div class=""section-title text-center mb-11"">
                        <h2 class=""title"">Follow Us Instagram</h2>
                        <p class=""sub-title"">To keep track of the latest, fastest, most affordable items.</p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <!-- Single Item -->
                <div class=""col-lg-3 col-md-6 col-sm-6 mb-md-30px mb-lm-30px"" data-aos=""fade-up"" data-aos-delay=""200"">
                    <div class=""insta-wrapper"">
                        <a href=""https://www.instagram.com/"" target=""_blank""><img class=""w-100"" src=""https://i.pinimg.com/345x/89/a8/8d/89a88d0eab8513f7a0fb1af998613b74.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 96611, "\"", 96617, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                        </a>
                    </div>
                </div>
                <!-- Single Item -->
                <div class=""col-lg-3 col-md-6 col-sm-6 mb-md-30px mb-lm-30px"" data-aos=""fade-up"" data-aos-delay=""400"">
                    <div class=""insta-wrapper"">
                        <a href=""https://www.instagram.com/"" target=""_blank""><img class=""w-100"" src=""https://www.fackelmann.co.in/productImage/50495_2-29.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 97070, "\"", 97076, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                        </a>
                    </div>
                </div>
                <!-- Single Item -->
                <div class=""col-lg-3 col-md-6 col-sm-6 mb-xs-30px"" data-aos=""fade-up"" data-aos-delay=""600"">
                    <div class=""insta-wrapper"">
                        <a href=""https://www.instagram.com/"" target=""_blank""><img class=""w-100"" src=""https://s3-eu-west-1.amazonaws.com/nedgis/public/images/products/lampe-a-poser-secto-4220-bouleau-naturel-led-o25cm-h75cm-secto-design/square_imgs/lampe-a-poser-secto-4220-bouleau-naturel-led-o25cm-h75cm-secto-design-normal.jpg?1639487380""");
            BeginWriteAttribute("alt", " alt=\"", 97700, "\"", 97706, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                        </a>
                    </div>
                </div>
                <!-- Single Item -->
                <div class=""col-lg-3 col-md-6 col-sm-6 "" data-aos=""fade-up"" data-aos-delay=""800"">
                    <div class=""insta-wrapper"">
                        <a href=""https://www.instagram.com/"" target=""_blank""><img class=""w-100"" src=""https://cf.shopee.vn/file/f2654612ba9ce9d07e6646c289a9d538""");
            BeginWriteAttribute("alt", " alt=\"", 98140, "\"", 98146, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n                <!-- Single Item -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Instagram Area End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
