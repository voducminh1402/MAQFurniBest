<<<<<<< HEAD
#pragma checksum "D:\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
=======
#pragma checksum "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
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
<<<<<<< HEAD
#line 1 "D:\MAQFurniBest\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 1 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "D:\MAQFurniBest\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 2 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
using MAQFurni.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "D:\MAQFurniBest\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 3 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
using MAQFurni.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "D:\MAQFurniBest\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 5 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
using MAQFurni.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 1 "D:\MAQFurniBest\Areas\Identity\Pages\Account\_ViewImports.cshtml"
=======
#line 1 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\Account\_ViewImports.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
using MAQFurni.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809c88577297f29a437af3767e8b4614e65bd482", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5449b8a98b47fefc762db168f939d2ecca5d55a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "D:\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
=======
#line 3 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
<<<<<<< HEAD
#line 6 "D:\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
=======
#line 6 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
<<<<<<< HEAD
#line 8 "D:\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
=======
#line 8 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 10 "D:\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
=======
#line 10 "C:\Users\HP\Desktop\prn22\MAQFurniBest\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
>>>>>>> 174df9c88fe538e45c48611a6a92502efb08862f
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
