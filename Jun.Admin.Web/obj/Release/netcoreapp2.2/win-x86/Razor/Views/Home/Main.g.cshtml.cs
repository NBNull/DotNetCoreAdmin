#pragma checksum "D:\githubcode\Jun.Admin.Core\Jun.Admin.Web\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac270c1553457a2c535efed2325cc991efc9107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main.cshtml", typeof(AspNetCore.Views_Home_Main))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac270c1553457a2c535efed2325cc991efc9107", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9840a7d7c9409be306e84ce764673a29a860d403", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1207, true);
            WriteLiteral(@"<div class=""layui-fluid"">
    <div class=""layui-row layui-col-space15"">
        <div class=""layui-col-md12"">
            <div class=""layui-card"">
                <div class=""layui-card-header"">
                    简介
                    <i class=""layui-icon layui-icon-tips"" lay-tips=""待完善"" lay-offset=""5""></i>
                </div>
                <div class=""layui-card-body layui-text layadmin-text"">
                    <p>1. DotNetCore+EFCore+layui的简易后台管理模板。</p>
                    <p>2. 前端页面现在只是展示布局，只支持列表数据呈现，前后端交互暂未实现，还存在许多样式问题，比如滚动条，tab标签与url的绑定，tab页的刷新等，后期有空完善。</p>
                    <p>3. 后端目前加了身份认证及授权验证，也有待完善，其他如缓存，日志，异常处理会慢慢补充。</p>
                    <p>4. 因为前后端没有交互，所以数据都是手动在数据库添加的，单纯为了页面显示，后端有些数据也是固定的。</p>
                    <p>5. 这个版本还很粗糙，肯定有许多不足之处，望见谅！</p>
                    <p>6. github源码：（<a href=""https://github.com/Jockeyson/DotNetCoreAdmin"" target=""_blank"">DotNetCoreAdmin</a>）</p>
                </div>
            </div>
        </div>
       </div>
</div>
<style>
    ");
            WriteLiteral(".layui-card-header .layui-icon {\r\n        line-height: initial;\r\n        position: absolute;\r\n        right: 15px;\r\n        top: 50%;\r\n        margin-top: -7px;\r\n    }\r\n    </style>\r\n");
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
