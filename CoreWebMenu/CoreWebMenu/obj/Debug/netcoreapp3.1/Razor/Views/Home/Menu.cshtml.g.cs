#pragma checksum "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90736ee484ab8634b9a0d449c19ba13e209a756d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
#line 1 "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\_ViewImports.cshtml"
using CoreWebMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\_ViewImports.cshtml"
using CoreWebMenu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90736ee484ab8634b9a0d449c19ba13e209a756d", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc833415b07d3bbe3a24d9936db5d116862009e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreWebMenu.Models.TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Menu Page";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>タスク一覧</h2>\r\n    <br>\r\n    <table>\r\n");
#nullable restore
#line 11 "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\Home\Menu.cshtml"
         foreach (var item in Model.tasks)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\Home\Menu.cshtml"
               Write(item.TaskId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 334, "\"", 354, 1);
#nullable restore
#line 16 "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\Home\Menu.cshtml"
WriteAttributeValue("", 341, item.TaskUrl, 341, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\Home\Menu.cshtml"
                                       Write(item.TaskNm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Peach\source\repos\CoreWebMenu\CoreWebMenu\Views\Home\Menu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreWebMenu.Models.TaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591