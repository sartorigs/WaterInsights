#pragma checksum "C:\Users\leona\Desktop\Codes\ProjetoAgua\projeto_agua\Projeto Aplicado\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b457308351dc6c136087b8a72faf5f4a9c23bfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
#line 1 "C:\Users\leona\Desktop\Codes\ProjetoAgua\projeto_agua\Projeto Aplicado\Views\_ViewImports.cshtml"
using Projeto_Aplicado;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leona\Desktop\Codes\ProjetoAgua\projeto_agua\Projeto Aplicado\Views\_ViewImports.cshtml"
using Projeto_Aplicado.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b457308351dc6c136087b8a72faf5f4a9c23bfd", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2039587772a3989760da8e7200e5ac60f4a6d452", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js""></script>
<div style=""position: relative"">
    <div style=""height 800px;width: 800px;position: absolute;top: 50%;left: 50%;margin: +150px 0 0 -230px;"">
        <div class=""row g-1 align-items-center"">
            <div class=""col-7"">
                <label for=""email"" class=""col-form-label"">E-mail</label>
                <input type=""email"" id=""email"" class=""form-control""> 
            </div>   
        </div>
        <div class=""row g-1 align-items-center"">
            <div class=""col-7"">
                <label for=""senha"" class=""col-form-label"">Senha</label>
                <input type=""password"" id=""senha"" class=""form-control"">
            </div>
        </div>
        <div style=""margin-top: 1rem; justify-content:space-between"" class=""row g-1"">
            <div class=""col-7"">
                <a style=""width: 110px"" href=""../Cadastro/Cadastro"" type=""submit"" class=""btn btn-danger"">Criar Conta</a>
                ");
            WriteLiteral(@"<button style=""width: 90px; float: right"" type=""submit"" class=""btn btn-primary"">Cadastrar</button>
            </div>
        </div>
    </div>
</div>


<script>
    var senha = $('#senha');
    var olho= $(""#olho"");

    olho.mousedown(function() {
      senha.attr(""type"", ""text"");
    });

    olho.mouseup(function() {
      senha.attr(""type"", ""password"");
    });
    $( ""#olho"" ).mouseout(function() { 
      $(""#senha"").attr(""type"", ""password"");
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
