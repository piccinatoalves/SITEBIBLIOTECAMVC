#pragma checksum "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\Home\Components\InfoProduto\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d1afe4a5c434ecad4449d6094f9576638766bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_InfoProduto_Default), @"mvc.1.0.view", @"/Views/Home/Components/InfoProduto/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d1afe4a5c434ecad4449d6094f9576638766bb", @"/Views/Home/Components/InfoProduto/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de59251c9d21b48cd0c7caa8b71b57fd10cad1d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_InfoProduto_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteBibliotecaMVC.Models.ViewModels.LivroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"alert alert-primary\" role=\"alert\">\r\n    ");
#nullable restore
#line 4 "C:\Users\picci\Desktop\SiteBibliotecaMVC\Views\Home\Components\InfoProduto\Default.cshtml"
Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteBibliotecaMVC.Models.ViewModels.LivroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
