#pragma checksum "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9a62b72d6c4667f80fc39be00495b76687e87f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConsolasExitoG61.App.Presentacion.Pages.CrudEmpleado.Pages_CrudEmpleado_Delete), @"mvc.1.0.razor-page", @"/Pages/CrudEmpleado/Delete.cshtml")]
namespace ConsolasExitoG61.App.Presentacion.Pages.CrudEmpleado
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a62b72d6c4667f80fc39be00495b76687e87f5", @"/Pages/CrudEmpleado/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a950f9e9b2e208933cb0fab03df2a157f91704d4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudEmpleado_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Empleado</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.CodEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.CodEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.accesoReportes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.accesoReportes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Clave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Clave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9a62b72d6c4667f80fc39be00495b76687e87f513108", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9a62b72d6c4667f80fc39be00495b76687e87f513375", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 84 "D:\Documentos\Grupo61\ConsolasExitoG61\ConsolasExitoG61.App\ConsolasExitoG61.App.Presentacion\Pages\CrudEmpleado\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9a62b72d6c4667f80fc39be00495b76687e87f515218", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsolasExitoG61.App.Presentacion.Pages.CrudEmpleado.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConsolasExitoG61.App.Presentacion.Pages.CrudEmpleado.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConsolasExitoG61.App.Presentacion.Pages.CrudEmpleado.DeleteModel>)PageContext?.ViewData;
        public ConsolasExitoG61.App.Presentacion.Pages.CrudEmpleado.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
