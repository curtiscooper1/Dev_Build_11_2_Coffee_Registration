#pragma checksum "C:\Users\ccooper2\dev\Lab_11_2_Coffee_Shop_Registration\Coffee_Shop\Views\Home\ShowRegistration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87460b5aa8d9feb022a30acb57a0505deffe2bac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowRegistration), @"mvc.1.0.view", @"/Views/Home/ShowRegistration.cshtml")]
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
#line 1 "C:\Users\ccooper2\dev\Lab_11_2_Coffee_Shop_Registration\Coffee_Shop\Views\_ViewImports.cshtml"
using Coffee_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ccooper2\dev\Lab_11_2_Coffee_Shop_Registration\Coffee_Shop\Views\_ViewImports.cshtml"
using Coffee_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87460b5aa8d9feb022a30acb57a0505deffe2bac", @"/Views/Home/ShowRegistration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb473e7b031f6336ea044efdcd6df3251d9be0ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowRegistration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ccooper2\dev\Lab_11_2_Coffee_Shop_Registration\Coffee_Shop\Views\Home\ShowRegistration.cshtml"
  
    ViewData["Title"] = "ShowRegistration";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome to the club ");
#nullable restore
#line 6 "C:\Users\ccooper2\dev\Lab_11_2_Coffee_Shop_Registration\Coffee_Shop\Views\Home\ShowRegistration.cshtml"
                   Write(ViewData["FirstName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\ccooper2\dev\Lab_11_2_Coffee_Shop_Registration\Coffee_Shop\Views\Home\ShowRegistration.cshtml"
                                          Write(ViewData["LastName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", look out for updates in your email(");
#nullable restore
#line 6 "C:\Users\ccooper2\dev\Lab_11_2_Coffee_Shop_Registration\Coffee_Shop\Views\Home\ShowRegistration.cshtml"
                                                                                                    Write(ViewData["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(")!</h1>\r\n\r\n");
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
