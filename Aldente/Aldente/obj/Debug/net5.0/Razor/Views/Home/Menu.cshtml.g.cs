#pragma checksum "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64807388b46a67621bf62b549d5a5bf90dab6a61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
#line 1 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\_ViewImports.cshtml"
using Aldente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\_ViewImports.cshtml"
using Aldente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64807388b46a67621bf62b549d5a5bf90dab6a61", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597b6f416e8f8b64037c44dc6ba566f6a52c9efa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aldente.Data.Entities.Platillo>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row my-5\">\r\n    <div class=\"col-lg-3\">\r\n        <div class=\"shadow rounded-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 214, "\"", 340, 1);
#nullable restore
#line 10 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
WriteAttributeValue("", 220, ViewBag.Logo != null ? "data:;base64,"+Convert.ToBase64String(ViewBag.Logo) :"/assets/images/burger-2013191_1280.png", 220, 120, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-9 flex-column justify-content-center d-flex\">\r\n        <p class=\"ftfoodsecret-regular fw-bold ftsize-65 ms-5\">");
#nullable restore
#line 14 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
                                                          Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"platillos\">\r\n");
#nullable restore
#line 19 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div class=\"bg-primarylightsam p-3 mb-2 rounded-4 ftfoodlist-regular ftcolor-white text-center\"\r\n       style=\"width: 18rem;\" name=\"categoria_subcategoria_nombre\">\r\n           <img");
            BeginWriteAttribute("src", " src=\"", 816, "\"", 941, 1);
#nullable restore
#line 23 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
WriteAttributeValue("", 822, item.Imagen != null ? "data:;base64,"+Convert.ToBase64String(item.Imagen) : "/assets/images/camera-1265913_1280.png", 822, 119, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid p-2 bg-white mb-3 rounded-4\" />\r\n           <div class=\"ftsize-22 fw-bold\">");
#nullable restore
#line 24 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
                                     Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n           <div class=\"ftsize-22 fw-bold\">345 gr.</div>\r\n           <div class=\"ftsize-35 fw-bold\">");
#nullable restore
#line 26 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
                                     Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n           <div class=\"ftsize-22\" align=\"justify\">\r\n               ");
#nullable restore
#line 28 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
          Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </div>\r\n           <div class=\"ftsize-22 fw-bold\">Tamaño: Grande</div>\r\n       </div>\n");
#nullable restore
#line 32 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Home\Menu.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aldente.Data.Entities.Platillo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
