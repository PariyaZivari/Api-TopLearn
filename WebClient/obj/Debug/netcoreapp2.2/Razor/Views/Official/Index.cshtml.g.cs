#pragma checksum "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33bcfbe511b9aa7d374334ab4c31b1a9b76c21e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Official_Index), @"mvc.1.0.view", @"/Views/Official/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Official/Index.cshtml", typeof(AspNetCore.Views_Official_Index))]
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
#line 1 "G:\Api\ApiTest\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#line 2 "G:\Api\ApiTest\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33bcfbe511b9aa7d374334ab4c31b1a9b76c21e5", @"/Views/Official/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Official_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OfficialViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(73, 501, true);
            WriteLiteral(@"
<h1>پرسنل رسمی </h1>
<table class=""table"">
    <thead>
        <tr>
            <th>  شماره پرسنلی </th>
            <th> نام و نام خانوادگی </th>
            <th> اضافه کار عادی </th>
            <th> اضاقه کار واقعی </th>
            <th>اضافه کار تعطیل </th>
            <th>اضافه کار واقعی تعطیل </th>
            <th>اضافه کار مدیریتی</th>
            <th>مجموع پرداختی </th>
            <th>از تاریخ </th>
            <th>تا تاریخ </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(623, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(684, 8, false);
#line 27 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.Pno);

#line default
#line hidden
            EndContext();
            BeginContext(692, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(760, 13, false);
#line 30 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(773, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(841, 12, false);
#line 33 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.Normale);

#line default
#line hidden
            EndContext();
            BeginContext(853, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(921, 16, false);
#line 36 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.RealTotalOv);

#line default
#line hidden
            EndContext();
            BeginContext(937, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1005, 11, false);
#line 39 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.EzafTp);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1084, 24, false);
#line 42 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.RealHolidayOvDouble);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1176, 17, false);
#line 45 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.EzafModiriat);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1261, 21, false);
#line 48 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.TotalHourPayment);

#line default
#line hidden
            EndContext();
            BeginContext(1282, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1350, 13, false);
#line 51 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.FromDate);

#line default
#line hidden
            EndContext();
            BeginContext(1363, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1431, 11, false);
#line 54 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
               Write(item.ToDate);

#line default
#line hidden
            EndContext();
            BeginContext(1442, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1511, "\"", 1540, 2);
            WriteAttributeValue("", 1518, "Official/Edit/", 1518, 14, true);
#line 57 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
WriteAttributeValue("", 1532, item.Id, 1532, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1541, 57, true);
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1598, "\"", 1629, 2);
            WriteAttributeValue("", 1605, "Official/Delete/", 1605, 16, true);
#line 58 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"
WriteAttributeValue("", 1621, item.Id, 1621, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1630, 78, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 61 "G:\Api\ApiTest\WebClient\Views\Official\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1721, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OfficialViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
