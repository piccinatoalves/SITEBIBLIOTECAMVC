#pragma checksum "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\Home\Components\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ee3d6086f0a78e848828406a5d11c1d93faf212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Default), @"mvc.1.0.view", @"/Views/Home/Components/Default.cshtml")]
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
#line 1 "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\_ViewImports.cshtml"
using SiteBibliotecaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\_ViewImports.cshtml"
using SiteBibliotecaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee3d6086f0a78e848828406a5d11c1d93faf212", @"/Views/Home/Components/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de59251c9d21b48cd0c7caa8b71b57fd10cad1d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<SiteBibliotecaMVC.Models.AutorSelectListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"col-md-10\">\r\n");
#nullable restore
#line 5 "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\Home\Components\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"checkbox\"\r\n            name=\"selectedAutores\"");
            BeginWriteAttribute("value", "\r\n            value=\"", 221, "\"", 255, 1);
#nullable restore
#line 9 "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\Home\Components\Default.cshtml"
WriteAttributeValue("", 242, item.AutorID, 242, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n            ");
#nullable restore
#line 10 "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\Home\Components\Default.cshtml"
        Write(Html.Raw(item.Selecionado ? "checked=\"checked\"" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /> ");
#nullable restore
#line 10 "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\Home\Components\Default.cshtml"
                                                                     Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 12 "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\Home\Components\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<SiteBibliotecaMVC.Models.AutorSelectListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591