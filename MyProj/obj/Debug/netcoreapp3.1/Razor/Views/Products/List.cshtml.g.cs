#pragma checksum "C:\Users\aveba\source\repos\MyProj\MyProj\Views\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf1925327c39884a5569e6b41cf80b7b9731b77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_List), @"mvc.1.0.view", @"/Views/Products/List.cshtml")]
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
#line 1 "C:\Users\aveba\source\repos\MyProj\MyProj\Views\_ViewImports.cshtml"
using MyProj.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf1925327c39884a5569e6b41cf80b7b9731b77", @"/Views/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5795a15a3f56c9bfc8641c5850b98f5031076faf", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>All products</h1>\r\n<h3>");
#nullable restore
#line 3 "C:\Users\aveba\source\repos\MyProj\MyProj\Views\Products\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 4 "C:\Users\aveba\source\repos\MyProj\MyProj\Views\Products\List.cshtml"
   
    foreach (var product in Model.AllProducts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p>Name: ");
#nullable restore
#line 8 "C:\Users\aveba\source\repos\MyProj\MyProj\Views\Products\List.cshtml"
            Write(product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p>Price: ");
#nullable restore
#line 9 "C:\Users\aveba\source\repos\MyProj\MyProj\Views\Products\List.cshtml"
             Write(product.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\aveba\source\repos\MyProj\MyProj\Views\Products\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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