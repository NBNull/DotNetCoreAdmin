#pragma checksum "D:\githubcode\Jun.Admin.Core\Jun.Admin.Web\Views\Right\Role\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9b3fb8eb37beaff3064b72f2c34dc6f30ffae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Right_Role_Update), @"mvc.1.0.view", @"/Views/Right/Role/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Right/Role/Update.cshtml", typeof(AspNetCore.Views_Right_Role_Update))]
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
#line 1 "D:\githubcode\Jun.Admin.Core\Jun.Admin.Web\Views\_ViewImports.cshtml"
using Jun.Admin.Web;

#line default
#line hidden
#line 2 "D:\githubcode\Jun.Admin.Core\Jun.Admin.Web\Views\_ViewImports.cshtml"
using Jun.Admin.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9b3fb8eb37beaff3064b72f2c34dc6f30ffae1", @"/Views/Right/Role/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9840a7d7c9409be306e84ce764673a29a860d403", @"/Views/_ViewImports.cshtml")]
    public class Views_Right_Role_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 952, true);
            WriteLiteral(@"<div class=""layui-form"">
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">角色名称:</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Name"" placeholder=""请输入"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">角色编码:</label>
            <div class=""layui-input-block"">
                <input type=""password"" name=""Code"" placeholder=""请输入"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">备注:</label>
            <div class=""layui-input-block"">
                <textarea placeholder=""请输入内容"" class=""layui-textarea""></textarea>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            BeginContext(1052, 99, true);
            WriteLiteral("<script>\r\n    layui.use(\'form\', function () {\r\n        var form = layui.form;\r\n\r\n    });\r\n</script>");
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
