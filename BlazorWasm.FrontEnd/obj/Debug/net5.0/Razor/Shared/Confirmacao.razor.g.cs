#pragma checksum "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67d5753aefc4084f1828dac6a2abb1f2eb8d1d3f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.FrontEnd.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasmServer.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Compartilhado.Entidades;

#line default
#line hidden
#nullable disable
    public partial class Confirmacao : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor"
 if (display)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"modal-backdrop show\"></div>");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "exemploConfirmacao");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalLabel =");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddAttribute(8, "style", "display:block;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddAttribute(11, "role", "document");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "modal-title");
            __builder.AddContent(18, 
#nullable restore
#line 12 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor"
                     Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor"
                                  onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "close");
            __builder.AddMarkupContent(24, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "modal-body");
            __builder.AddContent(28, 
#nullable restore
#line 20 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor"
                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "modal-footer");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor"
                                  onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-secondary");
            __builder.AddContent(36, "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor"
                                  onConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddContent(42, "Confirmar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\danil\OneDrive\Área de Trabalho\WasmSampleDotNet5\BlazorWasm.FrontEnd\Shared\Confirmacao.razor"
       
    private bool display = false;
    [Parameter] public string Titulo { get; set; } = "Confirmar";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public EventCallback onConfirm { get; set; }
    [Parameter] public EventCallback onCancel { get; set; }
    public void Show() => display = true;
    public void Hide() => display = false;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
