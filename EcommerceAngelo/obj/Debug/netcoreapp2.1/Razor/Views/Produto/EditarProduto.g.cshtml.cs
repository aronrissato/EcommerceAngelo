#pragma checksum "C:\Users\aron.rissato\source\repos\EcommerceAngelo\EcommerceAngelo\Views\Produto\EditarProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f7566a196f5c7c72bfd4941bd88718ee1b36bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_EditarProduto), @"mvc.1.0.view", @"/Views/Produto/EditarProduto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/EditarProduto.cshtml", typeof(AspNetCore.Views_Produto_EditarProduto))]
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
#line 1 "C:\Users\aron.rissato\source\repos\EcommerceAngelo\EcommerceAngelo\Views\_ViewImports.cshtml"
using EcommerceAngelo;

#line default
#line hidden
#line 2 "C:\Users\aron.rissato\source\repos\EcommerceAngelo\EcommerceAngelo\Views\_ViewImports.cshtml"
using EcommerceAngelo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7566a196f5c7c72bfd4941bd88718ee1b36bca", @"/Views/Produto/EditarProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac5e660f0d732af347bb4c8110ea62ada1c7845", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_EditarProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\aron.rissato\source\repos\EcommerceAngelo\EcommerceAngelo\Views\Produto\EditarProduto.cshtml"
  
    Produto p = ViewBag.Produto;
    DateTime dataHora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(115, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1757a99d5b154b378261a98f5089f660", async() => {
                BeginContext(121, 95, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>EditarProduto</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(225, 597, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed2487647a96411bb73535ce2c8e7847", async() => {
                BeginContext(231, 37, true);
                WriteLiteral("\r\n    <h1>Editar Produto</h1>\r\n\r\n    ");
                EndContext();
                BeginContext(268, 541, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02f72517931847bfb88474c95e8a1d05", async() => {
                    BeginContext(315, 74, true);
                    WriteLiteral("\r\n        <label>Nome: </label>\r\n        <input type=\"text\" name=\"txtNome\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 389, "\"", 404, 1);
#line 19 "C:\Users\aron.rissato\source\repos\EcommerceAngelo\EcommerceAngelo\Views\Produto\EditarProduto.cshtml"
WriteAttributeValue("", 397, p.Nome, 397, 7, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(405, 93, true);
                    WriteLiteral(" /><br />\r\n        <label>Descricao: </label>\r\n        <input type=\"text\" name=\"txtDescricao\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 498, "\"", 518, 1);
#line 21 "C:\Users\aron.rissato\source\repos\EcommerceAngelo\EcommerceAngelo\Views\Produto\EditarProduto.cshtml"
WriteAttributeValue("", 506, p.Descricao, 506, 12, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(519, 84, true);
                    WriteLiteral("/><br />\r\n        <label>Preço: </label>\r\n        <input type=\"text\" name=\"txtPreco\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 603, "\"", 619, 1);
#line 23 "C:\Users\aron.rissato\source\repos\EcommerceAngelo\EcommerceAngelo\Views\Produto\EditarProduto.cshtml"
WriteAttributeValue("", 611, p.Preco, 611, 8, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(620, 96, true);
                    WriteLiteral("/><br />\r\n        <label>Quantidade: </label>\r\n        <input type=\"number\" name=\"txtQuantidade\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 716, "\"", 737, 1);
#line 25 "C:\Users\aron.rissato\source\repos\EcommerceAngelo\EcommerceAngelo\Views\Produto\EditarProduto.cshtml"
WriteAttributeValue("", 724, p.Quantidade, 724, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(738, 64, true);
                    WriteLiteral("/><br />\r\n\r\n        <input type=\"submit\" value=\"Salvar\" />\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(809, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(822, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591