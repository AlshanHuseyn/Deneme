#pragma checksum "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b2ec7efc3301908b24fa1eb22b1c5744e3a561e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.Entity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b2ec7efc3301908b24fa1eb22b1c5744e3a561e", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe07369f566bae69b76347c3bd591e67ad487862", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Edura.WebUI.Infrastructure.PageLinktagHelper __Edura_WebUI_Infrastructure_PageLinktagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section id=\"content\">\n\n    <section id=\"shop\" class=\"container\">\n\n        <div class=\"row\">\n\n            <!-- sidebar start -->\n            <div id=\"sidebar\" class=\"col-md-3\">\n\n                <div class=\"widget\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b2ec7efc3301908b24fa1eb22b1c5744e3a561e5036", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control input-lg"" placeholder=""Search..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default btn-lg"" type=""submit""><i class=""fa fa-search""></i></button>
                            </span>
                        </div>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n\n\n                ");
#nullable restore
#line 28 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                ");
#nullable restore
#line 30 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml"
           Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
            <!-- sidebar end -->
            <!-- right column start -->
            <div class=""col-md-9"">

                <div class=""row"">

                    <div class=""col-md-12 wow fadeIn"" style=""visibility: visible; animation-name: fadeIn;"">
                        <div class=""row product-results"">
                            <div class=""product-results"">
                                <div class=""col-xs-8"">
                                    <p class=""woocommerce-result-count"">
                                        There are ");
#nullable restore
#line 44 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml"
                                             Write(Model.PagingInfo.TotalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </p>\n                                </div>\n\n                            </div>\n                        </div>\n                    </div>\n\n\n");
#nullable restore
#line 53 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml"
                     foreach (var product in Model.Products)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml"
                   Write(Html.Partial("_ProductItem", product));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml"
                                                              
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </div>\n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b2ec7efc3301908b24fa1eb22b1c5744e3a561e9240", async() => {
                WriteLiteral("\n\n                ");
            }
            );
            __Edura_WebUI_Infrastructure_PageLinktagHelper = CreateTagHelper<global::Edura.WebUI.Infrastructure.PageLinktagHelper>();
            __tagHelperExecutionContext.Add(__Edura_WebUI_Infrastructure_PageLinktagHelper);
#nullable restore
#line 61 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\List.cshtml"
__Edura_WebUI_Infrastructure_PageLinktagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Edura_WebUI_Infrastructure_PageLinktagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Edura_WebUI_Infrastructure_PageLinktagHelper.PageAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n            </div>\n            <!-- right column end -->\n\n        </div>\n\n\n\n    </section>\n\n\n\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
