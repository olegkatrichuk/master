#pragma checksum "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743828cae59b0f0c9f58fe5c5a21934a33afd674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductOfUser), @"mvc.1.0.view", @"/Views/Home/ProductOfUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ProductOfUser.cshtml", typeof(AspNetCore.Views_Home_ProductOfUser))]
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
#line 1 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\_ViewImports.cshtml"
using MyShop;

#line default
#line hidden
#line 2 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\_ViewImports.cshtml"
using MyShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743828cae59b0f0c9f58fe5c5a21934a33afd674", @"/Views/Home/ProductOfUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac74f13ce1837588570ccc8938c94d33e1ab613", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductOfUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyShop.Models.Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
  
    ViewData["Title"] = "ProductOfUser";

#line default
#line hidden
            BeginContext(92, 18, true);
            WriteLiteral("<p>Пользаватель : ");
            EndContext();
            BeginContext(111, 12, false);
#line 5 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
             Write(ViewBag.info);

#line default
#line hidden
            EndContext();
            BeginContext(123, 187, true);
            WriteLiteral("</p>\r\n<h2>Продукты для заказа</h2>\r\n\r\n<div>\r\n    <table class=\"table\">\r\n        <tr style=\"font-weight: bold\"><td>Название товара</td><td>Описание</td><td>Цена</td><td>Рейтинг</td></tr>\r\n");
            EndContext();
#line 11 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(359, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(390, 9, false);
#line 14 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(399, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(423, 16, false);
#line 15 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(439, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(463, 10, false);
#line 16 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(473, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(497, 11, false);
#line 17 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
           Write(item.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(508, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(531, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85b9d59c5cf34877a7437b51ee6ccc44", async() => {
                BeginContext(561, 6, true);
                WriteLiteral("Купить");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 540, "~/Home/Buy/", 540, 11, true);
#line 18 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
AddHtmlAttributeValue("", 551, item.Id, 551, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(571, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 20 "F:\Hillel\Elemen\elementary01\oleg_katrichuk\MyShop\MyShop\Views\Home\ProductOfUser.cshtml"
        }

#line default
#line hidden
            BeginContext(604, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyShop.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591