#pragma checksum "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\TwoFactorAuth\RecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0974ac9b46d04452372fa6fbd738535379cbe72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ECardManagment.Web.Pages.Settings.TwoFactorAuth.Pages_Settings_TwoFactorAuth_RecoveryCodes), @"mvc.1.0.razor-page", @"/Pages/Settings/TwoFactorAuth/RecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Settings/TwoFactorAuth/RecoveryCodes.cshtml", typeof(ECardManagment.Web.Pages.Settings.TwoFactorAuth.Pages_Settings_TwoFactorAuth_RecoveryCodes), null)]
namespace ECardManagment.Web.Pages.Settings.TwoFactorAuth
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0974ac9b46d04452372fa6fbd738535379cbe72", @"/Pages/Settings/TwoFactorAuth/RecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3134e5c3df3f8341ba5883cdcde71d211f01f794", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Settings_TwoFactorAuth_RecoveryCodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "GenerateNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\TwoFactorAuth\RecoveryCodes.cshtml"
  
    ViewData["Title"] = "2FA Recovery Codes";
    ViewData["ActiveMenu"] = "/Settings/Security";

#line default
#line hidden
            BeginContext(188, 1097, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Two Factor Authorization
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Settings</a></li>
        <li class=""active"">History</li>
    </ol>
</section>


<!-- Main content -->
<section class=""content"">

    <div class=""row"">
        <div class=""col-lg-2"">

        </div>
        <!-- /.col -->

        <div class=""col-lg-8"">

            <h4>2FA Recovery Codes</h4>
            <div class=""alert alert-warning"" role=""alert"">
                <p>
                    <span class=""glyphicon glyphicon-warning-sign""></span>
                    <strong>Put these codes in a safe place.</strong>
                </p>
                <p>
                    If you lose your device and don't have the recovery codes you will lose access to your account.
                </p>
            </div>
            <div class=""pan");
            WriteLiteral("el panel-primary panel-info\">\r\n                <div class=\"panel-body\">\r\n");
            EndContext();
#line 44 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\TwoFactorAuth\RecoveryCodes.cshtml"
                     for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
                    {

#line default
#line hidden
            BeginContext(1392, 143, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-6 text-center\">\r\n                                <h4>");
            EndContext();
            BeginContext(1536, 24, false);
#line 48 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\TwoFactorAuth\RecoveryCodes.cshtml"
                               Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(1560, 143, true);
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <div class=\"col-md-6 text-center\">\r\n                                <h4>");
            EndContext();
            BeginContext(1704, 28, false);
#line 51 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\TwoFactorAuth\RecoveryCodes.cshtml"
                               Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(1732, 75, true);
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 54 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\TwoFactorAuth\RecoveryCodes.cshtml"
                    }

#line default
#line hidden
            BeginContext(1830, 432, true);
            WriteLiteral(@"                </div>
                <div class=""panel-footer"">
                    <button class=""btn btn-primary""><i class=""fa fa-download""></i> Download</button>
                    <button class=""btn btn-primary""><i class=""fa fa-print""></i> Print</button>
                    <button class=""btn btn-primary""><i class=""fa fa-copy""></i> Copy</button>

                    <div class=""pull-right"">
                        ");
            EndContext();
            BeginContext(2262, 290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0974ac9b46d04452372fa6fbd738535379cbe728794", async() => {
                BeginContext(2282, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2312, 207, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0974ac9b46d04452372fa6fbd738535379cbe729207", async() => {
                    BeginContext(2400, 110, true);
                    WriteLiteral("\r\n                                <i class=\"fa fa-gears\"></i> Generate New Codes\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2519, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2552, 278, true);
            WriteLiteral(@"
                    </div>
                    
                </div>
            </div>
        </div>
        <!-- /.col -->

        <div class=""col-lg-2"">

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECardManagment.Web.Pages.Settings.TwoFactorAuth.RecoveryCodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ECardManagment.Web.Pages.Settings.TwoFactorAuth.RecoveryCodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ECardManagment.Web.Pages.Settings.TwoFactorAuth.RecoveryCodesModel>)PageContext?.ViewData;
        public ECardManagment.Web.Pages.Settings.TwoFactorAuth.RecoveryCodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
