#pragma checksum "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad382fc7c7277604aa284694f69af91623b20c8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\_ViewImports.cshtml"
using Student_Information;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\_ViewImports.cshtml"
using Student_Information.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad382fc7c7277604aa284694f69af91623b20c8f", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd7ae23c4c835c6dd69819cedcfb5e59c9218e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student_Information.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Student_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.degree_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 28 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 31 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Student_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.degree_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                ");
#nullable restore
#line 60 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\OSL\source\repos\Student Information\Student Information\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student_Information.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
