#pragma checksum "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\UI\Sliders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b30d7d564dd7dfda9f784e330cc8ac6117cf3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ECardManagment.Web.Pages.UI.Pages_UI_Sliders), @"mvc.1.0.razor-page", @"/Pages/UI/Sliders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UI/Sliders.cshtml", typeof(ECardManagment.Web.Pages.UI.Pages_UI_Sliders), null)]
namespace ECardManagment.Web.Pages.UI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\_ViewImports.cshtml"
using ECardManagment.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b30d7d564dd7dfda9f784e330cc8ac6117cf3b", @"/Pages/UI/Sliders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3134e5c3df3f8341ba5883cdcde71d211f01f794", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UI_Sliders : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/bootstrap-slider/css/bootstrap-slider.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/bootstrap-slider/bootstrap-slider.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\UI\Sliders.cshtml"
  
    ViewData["Title"] = "Sliders";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(90, 37, true);
                WriteLiteral("\r\n    <!-- bootstrap slider -->\r\n    ");
                EndContext();
                BeginContext(127, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22b30d7d564dd7dfda9f784e330cc8ac6117cf3b4793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(210, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(215, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(235, 37, true);
                WriteLiteral("\r\n    <!-- Bootstrap slider -->\r\n    ");
                EndContext();
                BeginContext(272, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22b30d7d564dd7dfda9f784e330cc8ac6117cf3b6460", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(343, 139, true);
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            /* BOOTSTRAP SLIDER */\r\n            $(\'.slider\').slider()\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(485, 6021, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Sliders
        <small>range sliders</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">UI</a></li>
        <li class=""active"">Sliders</li>
    </ol>
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box box-primary"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Bootstrap Slider</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <div class=""row margin"">
                        <div class=""col-sm-6"">
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" ");
            WriteLiteral(@"data-slider-orientation=""horizontal""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""red"">

                            <p>data-slider-id=""red""</p>
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""blue"">

                            <p>data-slider-id=""blue""</p>
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""green"">

    ");
            WriteLiteral(@"                        <p>data-slider-id=""green""</p>
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""yellow"">

                            <p>data-slider-id=""yellow""</p>
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""aqua"">

                            <p>data-slider-id=""aqua""</p>
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""");
            WriteLiteral(@"-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""purple"">

                            <p style=""margin-top: 10px"">data-slider-id=""purple""</p>
                        </div>
                        <div class=""col-sm-6 text-center"">
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""red"">
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value");
            WriteLiteral(@"=""[-100,100]"" data-slider-orientation=""vertical""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""blue"">
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""green"">
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""yellow"">
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-sl");
            WriteLiteral(@"ider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""aqua"">
                            <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                                   data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                                   data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""purple"">
                        </div>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
</section>
<!-- /.content -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SlidersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SlidersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SlidersModel>)PageContext?.ViewData;
        public SlidersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
