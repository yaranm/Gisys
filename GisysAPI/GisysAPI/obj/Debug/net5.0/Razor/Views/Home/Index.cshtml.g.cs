#pragma checksum "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a294b45cfeb1cfba13d6c393694bc99d73e45595"
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
#line 1 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\_ViewImports.cshtml"
using GisysAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\_ViewImports.cshtml"
using GisysAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a294b45cfeb1cfba13d6c393694bc99d73e45595", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f778811e37ed3e7a8a81f3f4e1ba4e9e27b023e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GisysAPI.ViewModels.EmployeeListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "All Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 5 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml"
Write(ViewBag.StatusCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml"
 if(Model.ListOfEmployee != null)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>All Employees</h2>\r\n<div>\r\n    <table class=\"table table-hover table-bordered box-style\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">Name</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 18 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml"
             foreach (var item in Model.ListOfEmployee)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"sortable\" role=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 523, "\"", 605, 5);
            WriteAttributeValue("", 533, "location.href", 533, 13, true);
            WriteAttributeValue(" ", 546, "=", 547, 2, true);
            WriteAttributeValue(" ", 548, "\'", 549, 2, true);
#nullable restore
#line 20 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 550, Url.Action("GetEmployee", "Home", new { id=item.Id }), 550, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 604, "\'", 604, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 21 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 24 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
#nullable restore
#line 28 "C:\GisysArbetsprov\GisysAPI\GisysAPI\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GisysAPI.ViewModels.EmployeeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
