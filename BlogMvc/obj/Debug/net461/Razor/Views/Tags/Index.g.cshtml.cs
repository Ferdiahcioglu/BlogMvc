#pragma checksum "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Tags\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d74365c0d0bb7929edcf5e5bafda111d634cf2ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Index), @"mvc.1.0.view", @"/Views/Tags/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tags/Index.cshtml", typeof(AspNetCore.Views_Tags_Index))]
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
#line 1 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\_ViewImports.cshtml"
using BlogMvc;

#line default
#line hidden
#line 2 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\_ViewImports.cshtml"
using BlogMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74365c0d0bb7929edcf5e5bafda111d634cf2ea", @"/Views/Tags/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c424dd8d6a919341ea9bcfb81d5d22179c71c42", @"/Views/_ViewImports.cshtml")]
    public class Views_Tags_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogMvc.Models.Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Tags\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 27, true);
            WriteLiteral("\r\n<h1>Tag Detail</h1>\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Tags\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(187, 8, true);
            WriteLiteral(" <h2><p>");
            EndContext();
            BeginContext(196, 17, false);
#line 13 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Tags\Index.cshtml"
   Write(item.ArticleTitle);

#line default
#line hidden
            EndContext();
            BeginContext(213, 18, true);
            WriteLiteral("</p></h2>\r\n    <p>");
            EndContext();
            BeginContext(232, 19, false);
#line 14 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Tags\Index.cshtml"
  Write(item.ArticleContent);

#line default
#line hidden
            EndContext();
            BeginContext(251, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Tags\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogMvc.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
