using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SEN_Locality_Finder
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAntiforgery(options =>
            {
                options.FormFieldName = "AntiforgeryFieldname"; //rendering anti-forgery tokens
                options.HeaderName = "X - CSRF - TOKEN - HEADERNAME"; //name of the header used by the web application
                options.SuppressXFrameOptionsHeader = false; //preventing User Interface spoofing (ClickJacking) to protect user data
            }); //preventing CSRF attacks

            services.AddHttpsRedirection(options =>
            {
                //temporary redirect status that will be displayed to the user
                options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                //backup alternative port number for HTTPS access on development environments
                options.HttpsPort = 5001;
            });

            services.AddHsts(options => //prevents cookie hijacking and protocol downgrading
            {
                options.Preload = true; //fresh install of HTTP Strict Transport Security (STS)
                options.IncludeSubDomains = true; //including sub-pages of the web application
                options.MaxAge = TimeSpan.FromDays(60); //prevention of using expired or invalid certificates
            }); //packet header security using transport layer


            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else if(env.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            //app.UseSession(); //session tokens for web application
            //ISessionStore sessionStore //namespace for session token

            //app.UseMvcWithDefaultRoute();
            app.UseMvc();
        }

    }
}
