#pragma checksum "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b85459489aa2251bc36677ab3ec3657280eb023c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ECardManagment.Web.Pages.Settings.Pages_Settings_Account), @"mvc.1.0.razor-page", @"/Pages/Settings/Account.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Settings/Account.cshtml", typeof(ECardManagment.Web.Pages.Settings.Pages_Settings_Account), null)]
namespace ECardManagment.Web.Pages.Settings
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85459489aa2251bc36677ab3ec3657280eb023c", @"/Pages/Settings/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3134e5c3df3f8341ba5883cdcde71d211f01f794", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Settings_Account : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formChangePassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\Account.cshtml"
  
    ViewData["Title"] = "Account";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(148, 786, true);
            WriteLiteral(@"<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        My Account
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Settings</a></li>
        <li class=""active"">My Account</li>
    </ol>
</section>


<!-- Main content -->
<section class=""content"">

    <div class=""row"">
        <div class=""col-lg-2"">

        </div>
        <!-- /.col -->

        <div class=""col-lg-8"">
            <!-- Account Settings -->
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Public profile</h3>
                </div>
                <div class=""box-body box-account"">
");
            EndContext();
            BeginContext(1122, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1142, 4186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85459489aa2251bc36677ab3ec3657280eb023c6000", async() => {
                BeginContext(1262, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2597, 2400, true);
                WriteLiteral(@"                        <div class=""form-group"">
                            <label for=""inputNewPassword"" class=""col-sm-2 control-label"">New Password</label>

                            <div class=""col-sm-10"">
                                <input type=""password"" class=""form-control"" id=""inputNewPassword"" name=""NewPassword"" placeholder=""New password""
                                       data-val=""true""
                                       data-val-length=""The Password must be at least 6 and at max 100 characters long.""
                                       data-val-length-max=""100""
                                       data-val-length-min=""6""
                                       data-val-regex=""The field Password must match the regular expression &#x27;^((?=.*[a-z])(?=.*[A-Z])(?=.*\d).&#x2B;$)&#x27;.""
                                       data-val-regex-pattern=""^((?=.*[a-z])(?=.*[A-Z])(?=.*\d).&#x2B;$)""
                                       data-val-required=""The Password field is req");
                WriteLiteral(@"uired."">
                                <span class=""field-validation-valid help-block""
                                      data-valmsg-for=""NewPassword""
                                      data-valmsg-replace=""true""></span>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""inputConfirmPassword"" class=""col-sm-2 control-label"">Confirm Password</label>

                            <div class=""col-sm-10"">
                                <input type=""password"" class=""form-control"" id=""inputConfirmPassword"" name=""ConfirmPassword"" placeholder=""Confirm password""
                                       data-val=""true""
                                       data-val-equalto=""The password and confirmation password do not match.""
                                       data-val-equalto-other=""NewPassword"">
                                <span class=""field-validation-valid help-block""
              ");
                WriteLiteral(@"                        data-valmsg-for=""ConfirmPassword""
                                      data-valmsg-replace=""true""></span>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                ");
                EndContext();
                BeginContext(4998, 23, false);
#line 94 "D:\Dev\Ecard\ECardManagment\Presentation\ECardManagment.Web\Pages\Settings\Account.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(5021, 300, true);
                WriteLiteral(@"
                                <button type=""submit"" class=""btn btn-primary"">Save</button>
                            </div>
                        </div>
                        <div id=""panelChangePasswordErrors"" class=""alert alert-danger"" style=""display:none;""></div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            BeginContext(5328, 295, true);
            WriteLiteral(@"
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
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
            DefineSection("Scripts", async() => {
                BeginContext(5641, 2686, true);
                WriteLiteral(@"
    <!-- Page script -->
    <script>
        $(function () {
            $(""#formChangePassword"").submit(function (e) {
                e.preventDefault();

                if (!$(""#formChangePassword"").valid())
                    return;

                var form = $(this);
                var data = form.serialize();

                $('#panelChangePasswordErrors').hide();
                $('#panelChangePasswordErrors').empty();

                $.ajax({
                    url: form.attr(""action""), // ""/Profile/ChangePassword"",
                    contentType: ""application/x-www-form-urlencoded; charset=utf-8"",
                    method: ""POST"",
                    data: data,
                    success: function (user) {
                        alert(""Password Changed!"");
                        form[0].reset();
                    },
                    error: function (jxqr, error, status) {
                        // парсинг json-объекта
                        console.l");
                WriteLiteral(@"og(jxqr);
                        console.log(error);
                        console.log(status);
                        if (jxqr.responseText === """") {
                            $('#panelChangePasswordErrors').append(""<p>"" + jxqr.statusText + ""</p>"");
                        }
                        else {
                            var response = JSON.parse(jxqr.responseText);
                            // добавляем общие ошибки модели
                            if (response) {

                                $.each(response, function (index, item) {
                                    $('#panelChangePasswordErrors').append(""<p>"" + item + ""</p>"");
                                });
                            }
                            // добавляем ошибки свойства Name
                            if (response['Name']) {

                                $.each(response['Name'], function (index, item) {
                                    $('#panelChangePasswordErrors').append(");
                WriteLiteral(@"""<p>"" + item + ""</p>"");
                                });
                            }
                            // добавляем ошибки свойства Age
                            if (response['Age']) {
                                $.each(response['Age'], function (index, item) {
                                    $('#panelChangePasswordErrors').append(""<p>"" + item + ""</p>"");
                                });
                            }
                        }

                        $('#panelChangePasswordErrors').show();
                    }
                })
            });
        })
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ECardManagment.Web.Services.Profile.ProfileManager ProfileManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountModel>)PageContext?.ViewData;
        public AccountModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
