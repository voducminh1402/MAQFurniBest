#pragma checksum "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "217667c0b35ed2a73be6c14cfda9f96742749186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Users/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\_ViewImports.cshtml"
using MAQFurni;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\_ViewImports.cshtml"
using MAQFurni.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"217667c0b35ed2a73be6c14cfda9f96742749186", @"/Areas/Users/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af0d8d46e9810ccc2630830b39b78eaeba22be4", @"/Areas/Users/Views/_ViewImports.cshtml")]
    public class Areas_Users_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MAQFurni.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("toolbox__search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-modal", new global::Microsoft.AspNetCore.Html.HtmlString("#editCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-items__link category-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/toast.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
  
  ViewData["Title"] = "Index";
  Layout = "_Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
  <div class=""page-header"">
    <h1 class=""page-header__title"">Users</h1>
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
                  <use xlink:href=""#icon-keyboard-right""><");
            WriteLiteral(@"/use>
                </svg></a>
            </li>
            <li class=""breadcrumbs__item active"">
              <span class=""breadcrumbs__link"">Users</span>
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
      <div class=""toolbox__left col-12 col-lg");
            WriteLiteral(@""">
        <div class=""toolbox__left-row row row--xs gutter-bottom-xs"">
          
          
          <div class=""form-group form-group--inline col-12 col-sm-auto d-none d-sm-block"">
            <div class=""toolbox__status input-group input-group--white input-group--append"">
              <input class=""input input--select"" type=""text"" value=""All status"" data-toggle=""dropdown"" readonly /><span
                class=""input-group__arrow"">
                <svg class=""icon-icon-keyboard-down"">
                  <use xlink:href=""#icon-keyboard-down""></use>
                </svg></span>
              <div class=""dropdown-menu dropdown-menu--right dropdown-menu--fluid js-dropdown-select"">
                <a class=""dropdown-menu__item active"" href=""#"" tabindex=""0"" data-value=""All status""><span
                    class=""marker-item""></span> All status</a>
                <a class=""dropdown-menu__item"" href=""#"" tabindex=""0"" data-value=""Complete""><span
                    class=""marker-item color-green""");
            WriteLiteral(@"></span>
                  Complete</a><a class=""dropdown-menu__item"" href=""#"" tabindex=""0"" data-value=""Pending""><span
                    class=""marker-item color-blue""></span>
                  Pending</a><a class=""dropdown-menu__item"" href=""#"" tabindex=""0"" data-value=""Processing""><span
                    class=""marker-item color-orange""></span>
                  Processing</a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class=""toolbox__right col-12 col-lg-auto"">
        <div class=""toolbox__right-row row row--xs flex-nowrap"">
          <div class=""col col-lg-auto"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "217667c0b35ed2a73be6c14cfda9f9674274918610948", async() => {
                WriteLiteral(@"
              <div class=""input-group input-group--white input-group--prepend"">
                <div class=""input-group__prepend"">
                  <svg class=""icon-icon-search"">
                    <use xlink:href=""#icon-search""></use>
                  </svg>
                </div>
                <input class=""input"" type=""text"" placeholder=""Search orders"" />
              </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
          <col width=""150px"" />
          <col width=""200px"" />
          <col width=""18%"" />
          <col />
          <col />
          
        </colgroup>
        <thead class=""table__header"">
          <tr class=""table__header-row"">
            <th style=""width: 30%;"" class=""table__th-sort"">
              <span class=""align-middle"">Username</span><span class=""sort sort--down""></span>
            </th>
");
            WriteLiteral("\r\n            <th style=\"width: 30%;\" class=\"table__th-sort\">\r\n              <span class=\"align-middle\">Email</span><span class=\"sort sort--down\"></span>\r\n            </th>\r\n");
            WriteLiteral(@"            <th class=""table__th-sort d-none d-sm-table-cell"">
              <span class=""align-middle"">Create Date</span><span class=""sort sort--down""></span>
            </th>
            <th class=""table__th-sort d-none d-sm-table-cell"">
              <span class=""align-middle"">User Status</span><span class=""sort sort--down""></span>
            </th>
            <th class=""table__actions""></th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 140 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
           foreach (var item in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table__row\">\r\n              <td class=\"d-none d-lg-table-cell table__td\">\r\n                <span class=\"text-grey\">");
#nullable restore
#line 144 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </td>\r\n");
            WriteLiteral("\r\n              <td class=\"table__td\"><span>");
#nullable restore
#line 148 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
            WriteLiteral("              <td class=\"table__td text-nowrap\">\r\n                <span class=\"text-grey\">");
#nullable restore
#line 153 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </td>\r\n              <td class=\"table__td text-nowrap\">\r\n                <span class=\"text-grey\">");
#nullable restore
#line 156 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.UserStatus.StatusName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
              </td>
              <td class=""table__td table__actions"">
                <div class=""items-more"">
                  <button class=""items-more__button"">
                    <svg class=""icon-icon-more"">
                      <use xlink:href=""#icon-more""></use>
                    </svg>
                  </button>
                  <div class=""dropdown-items dropdown-items--right"">
                    <div class=""dropdown-items__container"">
                      <ul class=""dropdown-items__list"">
                        <li class=""dropdown-items__item"">
                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "217667c0b35ed2a73be6c14cfda9f9674274918616986", async() => {
                WriteLiteral("<span class=\"dropdown-items__link-icon\">\r\n                              <svg class=\"icon-icon-archive\">\r\n                                <use xlink:href=\"#icon-archive\"></use>\r\n                              </svg></span>Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 169 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-cate-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 170 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-cate-name", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 170 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-cate-image", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 171 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        \r\n\r\n                        <li class=\"dropdown-items__item\">\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "217667c0b35ed2a73be6c14cfda9f9674274918621640", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "217667c0b35ed2a73be6c14cfda9f9674274918621927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 181 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <button type=""submit"" value=""Delete"" class=""dropdown-items__link category-delete""><span
                              class=""dropdown-items__link-icon""><svg class=""icon-icon-trash"">
                                  <use xlink:href=""#icon-trash""></use>
                                </svg></span>Delete</button>
                          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 180 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                      </ul>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </td>\r\n            </tr>\r\n");
#nullable restore
#line 194 "C:\Users\PhongVu\OneDrive\Máy tính\GroupProject_Group2\MAQFurni\Areas\Users\Views\Users\Index.cshtml"
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
</tbody>
</table>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "217667c0b35ed2a73be6c14cfda9f9674274918628431", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
 
   // Assuming ""?post=1234&action=edit""
window.addEventListener(""load"", () => {
var urlParams = new URLSearchParams(window.location.search);

console.log(urlParams.get('status')); // ""edit""
    if (urlParams.get('status') == ""fail""){
vt.error(""User is making order!"", {
            title: ""Delete fail"",
            position: ""top-right"",
            duration: 5000,
            closable: true,
            focusable: true,
            callback: undefined
        });
    }
  });
  
  
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MAQFurni.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
