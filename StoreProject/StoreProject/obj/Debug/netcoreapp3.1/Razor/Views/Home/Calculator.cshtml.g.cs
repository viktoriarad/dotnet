#pragma checksum "C:\Users\Viktoria\dotnet\StoreProject\StoreProject\Views\Home\Calculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a389e60dfbfd3ce9392d8013be0296667e5b7356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Calculator), @"mvc.1.0.view", @"/Views/Home/Calculator.cshtml")]
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
#line 1 "C:\Users\Viktoria\dotnet\StoreProject\StoreProject\Views\_ViewImports.cshtml"
using StoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Viktoria\dotnet\StoreProject\StoreProject\Views\_ViewImports.cshtml"
using StoreProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a389e60dfbfd3ce9392d8013be0296667e5b7356", @"/Views/Home/Calculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9a6473591d86c4bb45922d8666e135a9ef7e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Calculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Viktoria\dotnet\StoreProject\StoreProject\Views\Home\Calculator.cshtml"
  
    ViewData["Title"] = "Calculator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Viktoria\dotnet\StoreProject\StoreProject\Views\Home\Calculator.cshtml"
Write(await Html.RenderComponentAsync<StoreProject.Components.Calculator>(RenderMode.ServerPrerendered));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
