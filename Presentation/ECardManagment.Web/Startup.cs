using AutoMapper;
using ECardManagment.Extensions.AutoMapper;
using ECardManagment.Extensions.Filter;
using ECardManagment.Framework.Helpers;
using ECardManagment.Process.API.Auths;
using ECardManagment.Process.API.Dashboards;
using ECardManagment.Process.API.Rsvps;
using ECardManagment.Web.Services.Mail;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Project.Framework.Sessions;
using Project.Framework.WebService;
using System.Net;

namespace ECardManagment.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperConfig());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //services.AddAutoMapper(typeof(Startup));
            services.AddSession();

            services.AddMvc()
            .AddRazorPagesOptions(options =>
            {
                options.Conventions.AddFolderApplicationModelConvention("/", model => model.Filters.Add(new ValidatePageTokenFilter()));

                options.Conventions.AllowAnonymousToPage("/Error");
                options.Conventions.AllowAnonymousToPage("/Account/AccessDenied");
                options.Conventions.AllowAnonymousToPage("/Account/ConfirmEmail");
                options.Conventions.AllowAnonymousToPage("/Account/ExternalLogin");
                options.Conventions.AllowAnonymousToPage("/Account/ForgotPassword");
                options.Conventions.AllowAnonymousToPage("/Account/ForgotPasswordConfirmation");
                options.Conventions.AllowAnonymousToPage("/Account/Lockout");
                options.Conventions.AllowAnonymousToPage("/Account/Login");
                options.Conventions.AllowAnonymousToPage("/Account/LoginWith2fa");
                options.Conventions.AllowAnonymousToPage("/Account/LoginWithRecoveryCode");
                options.Conventions.AllowAnonymousToPage("/Account/Register");
                options.Conventions.AllowAnonymousToPage("/Account/ResetPassword");
                options.Conventions.AllowAnonymousToPage("/Account/ResetPasswordConfirmation");
                options.Conventions.AllowAnonymousToPage("/Account/SignedOut");
            })
            .SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.Configure<MailManagerOptions>(Configuration.GetSection("Email"));

            if (Configuration["Email:EmailProvider"] == "SendGrid")
            {
                services.Configure<SendGridAuthOptions>(Configuration.GetSection("Email:SendGrid"));
                services.AddSingleton<IMailManager, SendGridMailManager>();
            }
            else
            {
                services.AddSingleton<IMailManager, EmptyMailManager>();
            }

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<Services.Profile.ProfileManager>();

            // Web service
            services.AddSingleton<IRestSharpAuthenticatorFactory, RestSharpAuthenticatorFactory>();
            services.AddSingleton<IWebServiceExecutor, RestSharpServiceExecutor>();
            services.AddSingleton<IWebServiceExecutorFactory, RestSharpWebServiceExecutorFactory>();
            services.AddSingleton<IWebServiceResponse, WebServiceResponse>();

            //Process
            services.AddScoped<IAuthProcess, AuthProcess>();
            services.AddScoped<IDashboardProcess, DashboardProcess>();
            services.AddScoped<IRsvpProcess, RsvpProcess>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseStatusCodePages(async context =>
            {
                var request = context.HttpContext.Request;
                var response = context.HttpContext.Response;

                if (response.StatusCode == (int)HttpStatusCode.Forbidden)
                // you may also check requests path to do this only for specific methods       
                // && request.Path.Value.StartsWith("/specificPath")
                {
                    response.Redirect("/Account/login");
                }
            });

            //app.UseAuthentication();
            AppHttpContext.Services = app.ApplicationServices;
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Dashboards", action= "Index" });
            });

        }
    }
}
