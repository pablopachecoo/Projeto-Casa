#pragma checksum "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a68c2a9c455c10603754c55c823c88442d960e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Index), @"mvc.1.0.view", @"/Views/Eventos/Index.cshtml")]
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
#line 1 "C:\Users\POPF\Desktop\gitt\projectShow\Views\_ViewImports.cshtml"
using projectShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\POPF\Desktop\gitt\projectShow\Views\_ViewImports.cshtml"
using projectShow.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
using projectShow.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a68c2a9c455c10603754c55c823c88442d960e7", @"/Views/Eventos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3846e739a7be417a12a85cf9c864fddf86a1c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projectShow.Models.Eventos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comprar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
  
    var casas = ViewBag.casa;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"centralizar\">Eventos Atuais</h1>\n");
#nullable restore
#line 10 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
 if (User.Identity.IsAuthenticated && User.HasClaim("Admin", bool.TrueString) && (casas.Count >= 1))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <div class=\"centralizar\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a68c2a9c455c10603754c55c823c88442d960e75484", async() => {
                WriteLiteral("Criar novo Evento");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </p>\n");
#nullable restore
#line 17 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
} else if (casas.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">   
            <tr class=""centralizar"">
                <th> 
                    <div class=""alert alert-info"">                 
                        <h6><b>Cadastre uma Casa de Show para cadastrar o Evento</b></h6>
                    </div>       
                </th>
            </tr>
    </table>
");
#nullable restore
#line 28 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\n    <thead>\n        <tr class=\"centralizar\">\n            <th>\n                ");
#nullable restore
#line 33 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeDoEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CapacidadeDoevento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 39 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantidadeDeIngressos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 42 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataDoEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 45 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorDoIngresso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"cabecalho\" >\n                ");
#nullable restore
#line 48 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GeneroDoEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 51 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CasasDeShow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n        \n");
#nullable restore
#line 58 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"centralizar\">\n            <td>\n                ");
#nullable restore
#line 61 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeDoEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CapacidadeDoevento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 67 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantidadeDeIngressos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 70 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataDoEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 73 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorDoIngresso));

#line default
#line hidden
#nullable disable
            WriteLiteral(" R$\n            </td>\n            <td class=\"cabecalho\">\n                <div>");
#nullable restore
#line 76 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.GeneroDoEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 77 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                 if (item.GeneroDoEvento == "Rap")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img src=\"http://www.edmdistrict.com/wp-content/uploads/2015/12/Rap-Nation.png\" alt=\"RAP\" style=\"width:128px;height:128px;\">\n");
#nullable restore
#line 80 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                }else if(item.GeneroDoEvento == "Rock"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img src=\"https://thunderroadrocks.com/wp-content/uploads/2014/04/Guitar-Lessons-Thunder-Road-Icon-A.png\" alt=\"ROCK\" style=\"width:128px;height:128px;\">\n");
#nullable restore
#line 82 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                }else if(item.GeneroDoEvento == "Samba"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img src=\"https://1001freedownloads.s3.amazonaws.com/vector/thumb/64171/Pandeiro.png\" alt=\"SAMBA\" style=\"width:128px;height:128px;\">\n");
#nullable restore
#line 84 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n                ");
#nullable restore
#line 87 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CasasDeShow.NomeDaCasa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>            \n            <!-- checa se o usuário está logado e se tem a claim de Admin para exibir as opções de Editar, Deletar e ver detalhes-->\n\n");
#nullable restore
#line 91 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
             if (User.Identity.IsAuthenticated && User.HasClaim("Admin", bool.TrueString))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a68c2a9c455c10603754c55c823c88442d960e714005", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                                           WriteLiteral(item.EventosId);

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
            WriteLiteral(" |\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a68c2a9c455c10603754c55c823c88442d960e716170", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                                              WriteLiteral(item.EventosId);

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
            WriteLiteral(" |\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a68c2a9c455c10603754c55c823c88442d960e718341", async() => {
                WriteLiteral("Delete");
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
#line 96 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                                             WriteLiteral(item.EventosId);

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
            WriteLiteral("\n                </td>\n");
#nullable restore
#line 98 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a68c2a9c455c10603754c55c823c88442d960e720737", async() => {
                WriteLiteral("Comprar");
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
#line 100 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                                          WriteLiteral(item.EventosId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
                                                                           WriteLiteral(item.NomeDoEvento);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nome"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-nome", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nome"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n\n        </tr> \n");
#nullable restore
#line 104 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Eventos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projectShow.Models.Eventos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
