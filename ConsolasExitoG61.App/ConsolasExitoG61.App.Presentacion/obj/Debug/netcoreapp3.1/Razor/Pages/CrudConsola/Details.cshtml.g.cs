#pragma checksum "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56ce271c2494c4bcb1e5902488fdbb8a099c35e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConsolasExitoG61.App.Presentacion.Pages.CrudConsola.Pages_CrudConsola_Details), @"mvc.1.0.razor-page", @"/Pages/CrudConsola/Details.cshtml")]
namespace ConsolasExitoG61.App.Presentacion.Pages.CrudConsola
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
#line 1 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\_ViewImports.cshtml"
using ConsolasExitoG61.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56ce271c2494c4bcb1e5902488fdbb8a099c35e5", @"/Pages/CrudConsola/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a950f9e9b2e208933cb0fab03df2a157f91704d4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudConsola_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Consola</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.Referencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.Referencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.Version));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.Version));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.Fabricante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.Fabricante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.TipoDisco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.TipoDisco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.Almacenamiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.Almacenamiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.MemoriaRam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.MemoriaRam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.PrecioCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.PrecioCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consola.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consola.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56ce271c2494c4bcb1e5902488fdbb8a099c35e511634", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudConsola\Details.cshtml"
                           WriteLiteral(Model.Consola.id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56ce271c2494c4bcb1e5902488fdbb8a099c35e513830", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsolasExitoG61.App.Presentacion.Pages.CrudConsola.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConsolasExitoG61.App.Presentacion.Pages.CrudConsola.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConsolasExitoG61.App.Presentacion.Pages.CrudConsola.DetailsModel>)PageContext?.ViewData;
        public ConsolasExitoG61.App.Presentacion.Pages.CrudConsola.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
