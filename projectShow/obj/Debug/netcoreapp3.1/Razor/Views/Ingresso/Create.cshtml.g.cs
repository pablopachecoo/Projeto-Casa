#pragma checksum "C:\Users\POPF\Desktop\gitt\projectShow\Views\Ingresso\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed365efd467c47536e80f4111a2059d74b7f1592"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingresso_Create), @"mvc.1.0.view", @"/Views/Ingresso/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed365efd467c47536e80f4111a2059d74b7f1592", @"/Views/Ingresso/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3846e739a7be417a12a85cf9c864fddf86a1c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingresso_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projectShow.Models.Ingresso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Ingresso\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Ingresso\Create.cshtml"
  
    var evento = ViewBag.nome;
    var id = ViewBag.id;
    var intid = (int)id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"centralizar\">Comprando ingresso para o evento \"");
#nullable restore
#line 12 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Ingresso\Create.cshtml"
                                                     Write(evento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h1>\r\n<h4>Confirmar a compra ?</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <div asp-action=\"Create\">\r\n            <div style=\"centralizar\">\r\n");
#nullable restore
#line 19 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Ingresso\Create.cshtml"
                 using(Html.BeginForm("Create","Ingresso"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <input type=\"hidden\" name=\"EventosId\"");
            BeginWriteAttribute("value", " value=\"", 540, "\"", 554, 1);
#nullable restore
#line 21 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Ingresso\Create.cshtml"
WriteAttributeValue("", 548, intid, 548, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                 <input type=\"submit\" value=\"Comprar\" class=\"btn btn-primary\" />                 \r\n");
#nullable restore
#line 23 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Ingresso\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed365efd467c47536e80f4111a2059d74b7f15925395", async() => {
                WriteLiteral("Voltar Para a lista");
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\POPF\Desktop\gitt\projectShow\Views\Ingresso\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projectShow.Models.Ingresso> Html { get; private set; }
    }
}
#pragma warning restore 1591