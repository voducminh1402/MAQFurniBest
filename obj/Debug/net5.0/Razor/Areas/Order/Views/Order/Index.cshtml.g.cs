#pragma checksum "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb5348469ce8d9246ee6a6549884e1e24e15eeaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Order_Views_Order_Index), @"mvc.1.0.view", @"/Areas/Order/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\_ViewImports.cshtml"
using MAQFurni;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\_ViewImports.cshtml"
using MAQFurni.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb5348469ce8d9246ee6a6549884e1e24e15eeaf", @"/Areas/Order/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af0d8d46e9810ccc2630830b39b78eaeba22be4", @"/Areas/Order/Views/_ViewImports.cshtml")]
    public class Areas_Order_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MAQFurni.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumbs__link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("status"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input input--select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 12rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-filter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "find", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("toolbox__search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-items__link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
  
  ViewData["Title"] = "Index";
  Layout = "_Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
  <div class=""page-header"">
    <h1 class=""page-header__title"">Orders</h1>
  </div>
  <div class=""page-tools"">
    <div class=""page-tools__breadcrumbs"">
      <div class=""breadcrumbs"">
        <div class=""breadcrumbs__container"">
          <ol class=""breadcrumbs__list"">
            <li class=""breadcrumbs__item"">
              <a class=""breadcrumbs__link"" href=""index.html"">
                <svg class=""icon-icon-home breadcrumbs__icon"">
                  <use xlink:href=""#icon-home""></use>
                </svg>
                <svg class=""icon-icon-keyboard-right breadcrumbs__arrow"">
                  <use xlink:href=""#icon-keyboard-right""></use>
                </svg>
              </a>
            </li>
            <li class=""breadcrumbs__item disabled"">
              <a class=""breadcrumbs__link"" href=""#""><span>E-commerce</span>
                <svg class=""icon-icon-keyboard-right breadcrumbs__arrow"">
                  <use xlink:href=""#icon-keyboard-right""></u");
            WriteLiteral("se>\r\n                </svg></a>\r\n            </li>\r\n            <li class=\"breadcrumbs__item active\">\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb5348469ce8d9246ee6a6549884e1e24e15eeaf10111", async() => {
                WriteLiteral("<span>Orders</span>");
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
            WriteLiteral(@"

            </li>
          </ol>
        </div>
      </div>
    </div>
    <div class=""page-tools__right"">
      <div class=""page-tools__right-row"">
        <div class=""page-tools__right-item"">
          <a class=""button-icon"" href=""#""><span class=""button-icon__icon"">
              <svg class=""icon-icon-print"">
                <use xlink:href=""#icon-print""></use>
              </svg></span></a>
        </div>
        <div class=""page-tools__right-item"">
          <a class=""button-icon"" href=""#""><span class=""button-icon__icon"">
              <svg class=""icon-icon-import"">
                <use xlink:href=""#icon-import""></use>
              </svg></span></a>
        </div>
      </div>
    </div>
  </div>
  <div class=""toolbox"">
    <div class=""toolbox__row row gutter-bottom-xs"">
      <div class=""toolbox__left col-12 col-lg"">
        <div class=""toolbox__left-row row row--xs gutter-bottom-xs"">

");
            WriteLiteral("          <div class=\"form-group form-group--inline col-12 col-sm-auto d-none d-sm-block\">\r\n            <div class=\"toolbox__status input-group input-group--white input-group--append\">\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb5348469ce8d9246ee6a6549884e1e24e15eeaf12574", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb5348469ce8d9246ee6a6549884e1e24e15eeaf12849", async() => {
                    WriteLiteral("\r\n                  ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb5348469ce8d9246ee6a6549884e1e24e15eeaf13136", async() => {
                        WriteLiteral("All status");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 98 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.OrderStatus;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"toolbox__right col-12 col-lg-auto\">\r\n        <div class=\"toolbox__right-row row row--xs flex-nowrap\">\r\n          <div class=\"col col-lg-auto\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb5348469ce8d9246ee6a6549884e1e24e15eeaf17912", async() => {
                WriteLiteral(@"
              <div class=""input-group input-group--white input-group--prepend"">
                <div class=""input-group__prepend"">
                  <svg class=""icon-icon-search"">
                    <use xlink:href=""#icon-search""></use>
                  </svg>
                </div>
                <input name=""search"" class=""input"" type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5441, "\"", 5476, 1);
#nullable restore
#line 120 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
WriteAttributeValue("", 5455, ViewBag.SearchString, 5455, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n              </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class=""table-wrapper"">
    <div class=""table-wrapper__content table-collapse scrollbar-thin scrollbar-visible"" data-simplebar>
      <table class=""table table--lines"">
        <colgroup>
          <col width=""90px"" />
          <col width=""100px"" />
          <col width=""16%"" />
          <col />
          <col />
          <col />
          <col />
          <col />
        </colgroup>
        <thead class=""table__header"">
          <tr class=""table__header-row"">

            <th class=""table__th-sort"" style=""width: 20rem;"">
              <span>Order ID</span>
            </th>
            <th class=""table__th-sort"" style=""width: 16rem;"">
              <span class=""align-middle"">Customer Name</span><span class=""sort sort--down""></span>
            </th>

            <th class=""table__th-sort"">
              <span class=""align-middle"" style=""width: 10rem;"">Total</span><span class=""sort sort--down""></span>
 ");
            WriteLiteral(@"           </th>
            <th class=""table__th-sort"" style=""width: 15rem;"">
              <span class=""align-middle"">Date</span><span class=""sort sort--down""></span>
            </th>
            <th class=""table__th-sort d-none d-sm-table-cell"">
              <span class=""align-middle"">Status</span><span class=""sort sort--down""></span>
            </th>
            <th class=""table__actions""></th>
          </tr>
        </thead>
        <tbody id=""order-table"">
");
#nullable restore
#line 164 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
           foreach (var item in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table__row\">\r\n\r\n              <td class=\"table__td\" style=\"width: 20rem;\">\r\n                <span class=\"text-grey\">");
#nullable restore
#line 169 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </td>\r\n              <td class=\"table__td\" style=\"width: 16rem;\">");
#nullable restore
#line 171 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n              <td class=\"table__td\" style=\"width: 10rem;\"><span>");
#nullable restore
#line 173 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n              <td class=\"table__td text-nowrap\" style=\"width: 15rem;\">\r\n                <span class=\"text-grey\">");
#nullable restore
#line 175 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </td>\r\n              <td class=\"table__td text-nowrap\">\r\n                <span class=\"text-grey\">");
#nullable restore
#line 178 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ShippingInfo.Status.StatusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </td>\r\n              <td class=\"table__td table__actions\">\r\n\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb5348469ce8d9246ee6a6549884e1e24e15eeaf24611", async() => {
                WriteLiteral("<span\r\n                  class=\"dropdown-items__link-icon\">\r\n                    <svg class=\"icon-icon-view\">\r\n                      <use xlink:href=\"#icon-view\"></use>\r\n                    </svg></span>Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 183 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
                                                                       WriteLiteral(item.OrderId);

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
            WriteLiteral("\r\n\r\n              </td>\r\n            </tr>\r\n");
#nullable restore
#line 191 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Order\Views\Order\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
      </table>
    </div>
    <div class=""table-wrapper__footer"">
      <div class=""row"">
        <div class=""table-wrapper__show-result col text-grey"">
          <span class=""d-none d-sm-inline-block"">Showing</span> 1 to 10
          <span class=""d-none d-sm-inline-block"">of 50 items</span>
        </div>
        <div class=""table-wrapper__pagination col-auto"">
          <ol class=""pagination"">
            <li class=""pagination__item"">
              <a class=""pagination__arrow pagination__arrow--prev"" href=""#"">
                <svg class=""icon-icon-keyboard-left"">
                  <use xlink:href=""#icon-keyboard-left""></use>
                </svg>
              </a>
            </li>
            <li class=""pagination__item active"">
              <a class=""pagination__link"" href=""#"">1</a>
            </li>
            <li class=""pagination__item"">
              <a class=""pagination__link"" href=""#"">2</a>
            </li>
            <li class=""pagination__item"">
  ");
            WriteLiteral(@"            <a class=""pagination__link"" href=""#"">3</a>
            </li>
            <li class=""pagination__item pagination__item--dots"">...</li>
            <li class=""pagination__item"">
              <a class=""pagination__link"" href=""#"">10</a>
            </li>
            <li class=""pagination__item"">
              <a class=""pagination__arrow pagination__arrow--next"" href=""#"">
                <svg class=""icon-icon-keyboard-right"">
                  <use xlink:href=""#icon-keyboard-right""></use>
                </svg>
              </a>
            </li>
          </ol>
        </div>
      </div>
    </div>
  </div>
</div>


<style>
  .input-group {
    width: fit-content !important;
  }
</style>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
  function generateUUID() { // Public Domain/MIT
    var d = new Date().getTime();//Timestamp
    var d2 = ((typeof performance !== 'undefined') && performance.now && (performance.now() * 1000)) || 0;//Time in microseconds since page-load or 0 if unsupported
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
      var r = Math.random() * 16;//random number between 0 and 16
      if (d > 0) {//Use timestamp until depleted
        r = (d + r) % 16 | 0;
        d = Math.floor(d / 16);
      } else {//Use microseconds since page-load if supported
        r = (d2 + r) % 16 | 0;
        d2 = Math.floor(d2 / 16);
      }
      return (c === 'x' ? r : (r & 0x3 | 0x8)).toString(16);
    });
  }
  document.getElementById(""status"").addEventListener(""change"", () => document.getElementById(""form-filter"").submit());
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MAQFurni.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
