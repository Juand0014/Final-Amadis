#pragma checksum "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a131f1aa3a8be43e02e0255e2e420d82858b987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personas_Details), @"mvc.1.0.view", @"/Views/Personas/Details.cshtml")]
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
#line 1 "C:\Final\Iglesia\Iglesia\Views\_ViewImports.cshtml"
using Iglesia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Final\Iglesia\Iglesia\Views\_ViewImports.cshtml"
using Iglesia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a131f1aa3a8be43e02e0255e2e420d82858b987", @"/Views/Personas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93219e50eaf8fb62149cbf95f33073d1761f6b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Personas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Iglesia.Models.Persona>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    <h4>Persona</h4>\r\n    <hr />\r\n\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.telefonoPer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.telefonoPer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DocuIdentidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.DocuIdentidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.fechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaisNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaisNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CiudadNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.CiudadNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaisResidencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaisResidencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CiudadResidencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.CiudadResidencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstadoCivil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstadoCivil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hijos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hijos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ocupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ocupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 130 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TelefonoEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TelefonoEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 136 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaConversion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaConversion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 142 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaBautismo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 145 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaBautismo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 148 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaAceptado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 151 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaAceptado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 154 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Denominacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 157 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Denominacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 160 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreIglesia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 163 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreIglesia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 166 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IglesiaAnterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 169 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.IglesiaAnterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 172 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombrePastor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 175 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombrePastor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 178 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Disciplinado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 181 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Disciplinado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 184 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Causas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 187 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Causas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 190 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Funciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 193 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Funciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 196 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ministerios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 199 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ministerios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 202 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MinisterioMayorFruto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 205 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.MinisterioMayorFruto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 208 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MinisterioLlamado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 211 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.MinisterioLlamado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 214 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Metas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 217 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Metas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 220 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Respaldo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 223 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Respaldo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 226 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NivelEstudio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 229 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.NivelEstudio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 232 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExpulsadoIns));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 235 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExpulsadoIns));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 238 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Razon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 241 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Razon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a131f1aa3a8be43e02e0255e2e420d82858b98727548", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 246 "C:\Final\Iglesia\Iglesia\Views\Personas\Details.cshtml"
                           WriteLiteral(Model.PersonaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a131f1aa3a8be43e02e0255e2e420d82858b98729757", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div><br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Iglesia.Models.Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591
