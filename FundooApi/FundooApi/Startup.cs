// --------------------------------------------------------------------------------------------------------------------
// <copyright file="startup" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundooManager.Interface;
using FundooManager.Manager;
using FundooModel.Model.UserModels;
using FundooRepo.Context;
using FundooRepo.Interface;
using FundooRepo.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;

namespace FundooApi
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
            services.Configure<ApplicationSetting>(Configuration.GetSection("ApplicationSetting"));

            services.AddDbContextPool<UserContext>(options => options.UseSqlServer(Configuration.GetConnectionString("UserDBConncetion")));


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddTransient<IAccountManager, AccountManager>();

            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<ILabel, LabelManager>();

            services.AddTransient<ILabelRepository, LabelRepository>();

            services.AddTransient<INotes, NotesManager>();

            services.AddTransient<INotesRepository, NotesRepository>();
       
            //JWtAuthentication
            var key = Encoding.UTF8.GetBytes(Configuration["ApplicationSetting:JWT_Secret"].ToString());
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false; x.SaveToken = true; x.TokenValidationParameters = new TokenValidationParameters { ValidateIssuerSigningKey = true, IssuerSigningKey = new SymmetricSecurityKey(key), ValidateIssuer = false, ValidateAudience = false };
            });

                services.AddSwaggerGen(c => {
               c.SwaggerDoc("v1", new Info
               {
                   Version = "v1",
                  Title = "Test API",
                  Description = "ASP.NET Core Web API"
               });
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
            //app.UseSwagger();
            //app.UseSwaggerUI(c => {
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1");
            //});
        }
    }
}














