#pragma checksum "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c11240e463c499ea8bafa506c6e80f0eb815a71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Details), @"mvc.1.0.view", @"/Views/Eventos/Details.cshtml")]
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
#line 1 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\_ViewImports.cshtml"
using GerenciadorDeEventos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\_ViewImports.cshtml"
using GerenciadorDeEventos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c11240e463c499ea8bafa506c6e80f0eb815a71", @"/Views/Eventos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0aab0438d3dc87b4cd6644a45fa7ac89418dca", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GerenciadorDeEventos.Models.Evento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><b>");
#nullable restore
#line 7 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml"
  Write(Html.DisplayFor(model => model.NomeEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h1>\r\n\r\n\r\n    <h4>Data: ");
#nullable restore
#line 10 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml"
         Write(Html.DisplayFor(model => model.DataEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Local: ");
#nullable restore
#line 11 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml"
          Write(Html.DisplayFor(model => model.LocalEvento.NomeLocal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n      <h4>Gênero: ");
#nullable restore
#line 12 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml"
             Write(Html.DisplayFor(model => model.GeneroEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n\r\n    <div class=\"row container\">\r\n        <div class=\"col-sm-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 460, "\"", 511, 1);
#nullable restore
#line 17 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml"
WriteAttributeValue("", 466, Html.DisplayFor(model => model.ImagemEvento), 466, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" width=\"600\" height=\"600\">\r\n        </div>\r\n\r\n        <div class=\"col-sm-8\">\r\n            <h5><b>");
#nullable restore
#line 21 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml"
              Write(Html.DisplayNameFor(model => model.DescricaoEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </b></h5>\r\n            <h6>");
#nullable restore
#line 23 "C:\Users\ricar\OneDrive - Fatec Centro Paula Souza\projects\treinamento_gft_cs\GerenciadorDeEventos\Views\Eventos\Details.cshtml"
           Write(Html.DisplayFor(model => model.DescricaoEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h6>     \r\n        </div>\r\n\r\n    </div>\r\n\r\n<hr />\r\n           \r\n        \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GerenciadorDeEventos.Models.Evento> Html { get; private set; }
    }
}
#pragma warning restore 1591