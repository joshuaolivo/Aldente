#pragma checksum "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a63c8ee7c44eef1307eed479880022180b5a1d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Platillos_Show), @"mvc.1.0.view", @"/Views/Platillos/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a63c8ee7c44eef1307eed479880022180b5a1d2", @"/Views/Platillos/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597b6f416e8f8b64037c44dc6ba566f6a52c9efa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Platillos_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aldente.Data.Entities.Platillo>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnsuccess-sam px-3 m-1 btn-sam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Actualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p class=\"ftfoodsecret-regular ftsize-85 fw-bold mt-5 mb-3 text-center\">");
#nullable restore
#line 7 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                                                   Write(ViewBag.RestauranteNombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div class=\"shadow rounded-4 p-1 mb-2 mx-auto\" style=\"width: 210px; height: 210px;\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 296, "\"", 446, 1);
#nullable restore
#line 10 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
WriteAttributeValue("", 302, ViewBag.RestauranteLogo != null ? "data:;base64," + Convert.ToBase64String(ViewBag.RestauranteLogo): "/assets/images/burger-2013191_1280.png", 302, 144, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top rounded-4"">
</div>

<div class=""my-3 mt-5"">
    <div class=""row"">
        <div class=""col-lg-6"">
            <h2 class=""ftfoodsecret-regular fw-bold"">Lista de platillos</h2>
            <div class=""lineseparator""></div>
        </div>
        <div class=""col-lg-6 justify-content-end d-flex"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a63c8ee7c44eef1307eed479880022180b5a1d27031", async() => {
                WriteLiteral(@"
                Agregar nuevo platillo
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor""
                class=""bi bi-plus-lg ms-1"" viewBox=""0 0 16 16"">
                    <path fill-rule=""evenodd""
                    d=""M8 2a.5.5 0 0 1 .5.5v5h5a.5.5 0 0 1 0 1h-5v5a.5.5 0 0 1-1 0v-5h-5a.5.5 0 0 1 0-1h5v-5A.5.5 0 0 1 8 2Z"" />
                </svg>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a63c8ee7c44eef1307eed479880022180b5a1d28746", async() => {
                WriteLiteral(@"
    <div class=""container bg-veige p-4 rounded ftfoodsecret-regular ftsize-22 fw-bold"">
        <div class=""row my-1"">
            <div class=""col-md-2 ftcolor-orange"">
                Buscar elemento
            </div>
            <div class=""col-md-10"">
                <input name=""busqueda"" id=""busqueda"" type=""text"" placeholder=""Nombre del elemento..."" class=""w-100 textbox-sam px-3 py-1""
                        required />
            </div>
        </div>
        <hr style=""background-color: #F4B700; border: none; height: 3px;"" />
        <div class=""row my-1"">
            <div class=""row"">
                <div class=""col ftcolor-orange"">
                    Filtrar busqueda por:
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-2 ftcolor-orange"">
                    Categoria:
                </div>
                <div class=""col-md-4"">
                    <select name=""categoria"" id=""categoria"" aria-placeholder=""Selecciona");
                WriteLiteral("r\"\r\n                    class=\"w-100 textbox-sam px-3 py-1 dropdown-sam\" onchange=\"changeSubCatsElems();\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a63c8ee7c44eef1307eed479880022180b5a1d210238", async() => {
                    WriteLiteral("Categoria");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 58 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                         foreach (var cat in ViewBag.Categorias)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a63c8ee7c44eef1307eed479880022180b5a1d212218", async() => {
#nullable restore
#line 60 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                               Write(cat.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                               WriteLiteral(cat.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 61 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <div class=""col-md-2 ftcolor-orange"">
                    Subcategoria
                </div>
                <div class=""col-md-4"">
                    <select name=""subcategoria"" id=""subcategoria"" aria-placeholder=""Seleccionar""
                    class=""w-100 textbox-sam px-3 py-1 dropdown-sam"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a63c8ee7c44eef1307eed479880022180b5a1d214723", async() => {
                    WriteLiteral("Subcategoria");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                
            </div>
            <div class=""row w-100 justify-content-center pt-1"">
                <input type=""submit"" class=""btn btn-dark w-50 ftsize-22"" value=""Buscar"" />
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<div name=\"platillos\" class=\"my-3\">\r\n");
#nullable restore
#line 84 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"rounded-4 shadow w-100 my-3\">\r\n        <div class=\"bg-secondarysam ftfoodlist-regular text-center p-1 rounded-top-4 fw-bolder ftsize-27\">\r\n            ");
#nullable restore
#line 87 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
       Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"bg-white p-2 rounded-bottom-4\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3939, "\"", 4064, 1);
#nullable restore
#line 92 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
WriteAttributeValue("", 3945, item.Imagen != null ? "data:;base64,"+Convert.ToBase64String(item.Imagen) : "/assets/images/camera-1265913_1280.png", 3945, 119, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid p-2 img-thumbnail"" />
                </div>
                <div class=""col-md-8 ftsize-22"">
                    <div class=""row"">
                        <div class=""col-sm-3"">
                            <span class=""ftfoodsecret-regular fw-bold"">Tamaño: </span><span class=""ftfoodlist-regular"">");
#nullable restore
#line 97 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                                                                                                  Write(Html.DisplayFor(modelItem => item.Tamanio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"col-sm-5\">\r\n                            <span class=\"ftfoodsecret-regular fw-bold\">Proporcion: </span><span  class=\"ftfoodlist-regular\">");
#nullable restore
#line 100 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                                                                                                       Write(Html.DisplayFor(modelItem => item.Proporcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span  class=\"ftfoodlist-regular\">");
#nullable restore
#line 100 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                                                                                                                                                                                              Write(Html.DisplayFor(modelItem => item.Unidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"col-sm-4\">\r\n                            <span class=\"ftfoodsecret-regular fw-bold ftcolor-green\">Precio: </span><span class=\"ftfoodlist-regular\">$ ");
#nullable restore
#line 103 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                                                                                                                  Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <span class=""ftfoodsecret-regular fw-bold"">Categoria: </span><span class=""ftfoodlist-regular"">");
#nullable restore
#line 108 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                                                                                                     Write(Html.DisplayFor(modelItem => item.Categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"col-sm-4\">\r\n                            <span class=\"ftfoodsecret-regular fw-bold\">Subcategoria: </span><span\r\n                            class=\"ftfoodlist-regular\">");
#nullable restore
#line 112 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.SubCategoia.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <div class=""row mt-1"">
                        <div class=""row"">
                            <span class=""ftfoodsecret-regular fw-bold"">Descripcion: </span>
                        </div>
                        <div class=""row"">
                            <span class=""ftfoodlist-regular"">
                                ");
#nullable restore
#line 121 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-1 d-flex flex-column justify-content-around\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a63c8ee7c44eef1307eed479880022180b5a1d223764", async() => {
                WriteLiteral(@"
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""40"" height=""40""
                        fill=""currentColor"" class=""bi bi-pencil-fill btnedit-sam"" viewBox=""0 0 16 16"">
                            <path
                            d=""M12.854.146a.5.5 0 0 0-.707 0L10.5 1.793 14.207 5.5l1.647-1.646a.5.5 0 0 0 0-.708l-3-3zm.646 6.061L9.793 2.5 3.293 9H3.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.207l6.5-6.5zm-7.468 7.468A.5.5 0 0 1 6 13.5V13h-.5a.5.5 0 0 1-.5-.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.5-.5V10h-.5a.499.499 0 0 1-.175-.032l-.179.178a.5.5 0 0 0-.11.168l-2 5a.5.5 0 0 0 .65.65l5-2a.5.5 0 0 0 .168-.11l.178-.178z"" />
                        </svg>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a63c8ee7c44eef1307eed479880022180b5a1d226709", async() => {
                WriteLiteral(@"
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""40"" height=""40""
                        fill=""currentColor"" class=""bi bi-trash-fill btndelete-sam"" viewBox=""0 0 16 16"">
                            <path
                            d=""M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z"" />
                        </svg>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 134 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 145 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<script>\r\n    function changeSubCatsElems() {\r\n        const subCats = ");
#nullable restore
#line 150 "F:\elagu\Documentos\GitHub\Aldente\Aldente\Aldente\Views\Platillos\Show.cshtml"
                   Write(Html.Raw(Json.Serialize(ViewBag.SubCategorias)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        var selectP = document.getElementById(""categoria"");
        var selectS = document.getElementById(""subcategoria"");
        selectS.removeAttribute(""disabled"");
        $(""#subcategoria"").empty();
        selectS.options.add(new Option(""Subcategoria"", """", false, true));
        selectS.options[0].disabled = true;
        for (var e in subCats) {
            if (subCats[e].categorias_Id.id == selectP.value) {
                selectS.options.add(new Option(subCats[e].nombre, subCats[e].id));
            }
        }
    }
</script>");
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
