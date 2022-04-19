using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormAdd;
using ET.Application.Infrastructure.EmailSender;
using ET.Application.Infrastructure.Filters;
using ET.Application.Infrastructure.Helpers;
using ET.Application.Infrastructure.StorageManager;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.DataAccess.Repository;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Hangfire;
using Newtonsoft.Json;
using FluentValidation.AspNetCore;

namespace ET_NetCore.API
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
            services.AddDbContext<ETContext>(x => x.UseSqlServer(Configuration.GetConnectionString("ETConnection")));

            IdentityBuilder builder = services.AddIdentityCore<User>(opt =>
            {
                // Password settings.
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 4;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.User.RequireUniqueEmail = true;
                opt.SignIn.RequireConfirmedEmail = false;

                // Lockout settings.
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                opt.Lockout.MaxFailedAccessAttempts = 5;
                opt.Lockout.AllowedForNewUsers = true;

                opt.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider;
            }).AddDefaultTokenProviders();


            builder = new IdentityBuilder(builder.UserType, typeof(Role), builder.Services);
            builder.AddEntityFrameworkStores<ETContext>();
            builder.AddRoleValidator<RoleValidator<Role>>();
            builder.AddRoleManager<RoleManager<Role>>();
            builder.AddSignInManager<SignInManager<User>>();

            services.AddMvc(
                    options =>
                    {
                        var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                        options.Filters.Add(new AuthorizeFilter(policy));
                        options.Filters.Add(typeof(CustomExceptionFilterAttribute));
                    }
                ).SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                })
                .AddFluentValidation(fv =>
                    {
                        fv.RegisterValidatorsFromAssemblyContaining<MainFormAddCommandValidator>();
                        fv.ImplicitlyValidateChildProperties = true;
                    }
                );

            // requires
            // using Microsoft.AspNetCore.Identity.UI.Services;
            // using WebPWrecover.Services;
            services.AddSingleton<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);
            services.AddHangfire(x=>x.UseSqlServerStorage(Configuration.GetConnectionString("ETConnection")));
            services.AddAutoMapper();
            services.AddHttpContextAccessor();
            services.AddCors();
            services.AddMediatR();
            
            // services.AddMediatR(typeof(SomeHandler).Assembly,typeof(SomeOtherHandler).Assembly);
       
            services.AddTransient<Seed>();
            services.AddScoped<IIndividualRepository, IndividualRepository>();
            services.AddScoped<IIITRLodgementRepository, IITRLodgementRepository>();
            services.AddScoped<IMainformRepository, MainFormRepository>();
            services.AddScoped<IStorageManager, StorageManager>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey =
                        new SymmetricSecurityKey(
                            Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                });

            //can set multiple roles rule
            services.AddAuthorization(opt =>
            {
                opt.AddPolicy("RequireMember", policy => policy.RequireRole("Member"));
                opt.AddPolicy("RequireSuperAdmin", policy => policy.RequireRole("SuperAdmin","Member"));
                opt.AddPolicy("RequirePremiumAccount", policy => policy.RequireRole("PremiumAccount"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Seed seeder)
        {

        
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();    
            }
            else
            {
                app.UseExceptionHandler(builder =>
                {
                    builder.Run(async context =>
                    {
                        context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;

                        var error = context.Features.Get<IExceptionHandlerFeature>();
                        if (error != null)
                        {
                            context.Response.AddApplicationError(error.Error.Message);
                            await context.Response.WriteAsync(error.Error.Message);
                        }
                    });
                });
                //app.UseHsts();
            }
            seeder.SeedData();
            app.UseHangfireDashboard();
            app.UseHangfireServer();
            app.UseCors(builder =>
            {
                builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            });
            app.UseAuthentication();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            //app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "api/{controller}/{action}/{id?}");
            });
        }
    }
}
