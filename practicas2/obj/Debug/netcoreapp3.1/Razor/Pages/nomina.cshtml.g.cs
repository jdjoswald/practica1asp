#pragma checksum "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9feb491bf5cf5ac7d3ea9823374cbd2188912a4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(practicas2.Pages.Pages_nomina), @"mvc.1.0.razor-page", @"/Pages/nomina.cshtml")]
namespace practicas2.Pages
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
#line 1 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\_ViewImports.cshtml"
using practicas2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9feb491bf5cf5ac7d3ea9823374cbd2188912a4d", @"/Pages/nomina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ab03e6b51f5e6cab46e94238af1bd45c0be3e8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_nomina : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""text-center"">
    <h1 class=""display-4"">Nomina</h1>
   

</div>

<table>
    <tr>

        <th> nombres</th>
        <th>apellidos</th>
        <th>cargo</th>
        <th>  salario mensual</th>
        <th>descuento AFP</th>
        <th>descuento ARS</th>

        <th>descuento ISR</th>
        <th>total de descuentos</th>
        <th> Salario Neto</th>

    </tr>
");
#nullable restore
#line 29 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
     foreach (var item in Model.lista)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(item.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 34 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(item.cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 35 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(item.salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td>");
#nullable restore
#line 37 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(Model.seguro(@item.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 38 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(Model.admin(@item.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 39 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(Model.imp(@item.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td>");
#nullable restore
#line 41 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(Model.total_desc(@item.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 42 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
   Write(Model.neto(@item.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</tr>\r\n");
#nullable restore
#line 52 "C:\Users\laraw\source\repos\practicas2\practicas2\Pages\nomina.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<practicas2.Pages.nominaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<practicas2.Pages.nominaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<practicas2.Pages.nominaModel>)PageContext?.ViewData;
        public practicas2.Pages.nominaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
