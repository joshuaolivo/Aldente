#pragma checksum "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e358bb48701b05b3b4d5e875783908351b4d183e"
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
#line 1 "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\_ViewImports.cshtml"
using Aldente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\_ViewImports.cshtml"
using Aldente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e358bb48701b05b3b4d5e875783908351b4d183e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597b6f416e8f8b64037c44dc6ba566f6a52c9efa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aldente.Data.Entities.Restaurante>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""containerbanner"">
    <img src=""/assets/images/food-3594552_1920.jpg"" class=""img-fluid imgindexbanner w-100 my-4 rounded-4"" />
    <div class=""imgtext-bl text-start gradient-overlay rounded-bottom-4"">
        <div class=""ftrestaurant-regular fw-bolder ftsize-85 mb-0"">SAM</div>
            <span class=""ftfoodsecret-regular ftsize-35"">Sistema de Almacenamiento de Menus</span>
    </div>
</div>
<div class=""my-3"">
    <h2 class=""ftfoodsecret-regular fw-bold"">Restaurantes</h2>
    <div class=""lineseparator""></div>
</div>
<div name=""restaurantes"" class=""my-3 d-flex flex-wrap justify-content-between"">
");
#nullable restore
#line 21 "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\Home\Index.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"card rounded-4 mb-2 card-shadow card-text\" style=\"width: 18rem;\" role=\"button\"");
            BeginWriteAttribute("id", " id=\"", 904, "\"", 933, 2);
            WriteAttributeValue("", 909, "restaurante_", 909, 12, true);
#nullable restore
#line 22 "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\Home\Index.cshtml"
WriteAttributeValue("", 921, item.Nombre, 921, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"menu.html\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 966, "\"", 1087, 1);
#nullable restore
#line 23 "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\Home\Index.cshtml"
WriteAttributeValue("", 972, item.Logo != null ? "data:;base64,"+Convert.ToBase64String(item.Logo) : "/assets/images/burger-2013191_1280.png", 972, 115, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top rounded-top-4\">\r\n        <div class=\"card-body bg-secondarysam rounded-bottom-4\">\r\n            <h3 class=\"card-title ftfoodlist-regular ftsize-35 fw-bold text-center\">");
#nullable restore
#line 25 "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\Home\Index.cshtml"
                                                                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n    </a>\r\n");
#nullable restore
#line 28 "D:\UPIICSA\7mo Semestre\DotNet\Proyecto\Aldente\Aldente\Aldente\Aldente\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aldente.Data.Entities.Restaurante>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
