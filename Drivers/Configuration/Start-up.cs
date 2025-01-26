using System.Text;
using Drivers.Data;
using Drivers.Mapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Drivers.Configuration
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // ثبت سرویس‌های برنامه
        public void ConfigureServices(IServiceCollection services)
        {
            // تنظیمات JWT از appsettings.json
            services.Configure<JwtConfig>(_configuration.GetSection("JwtConfig"));

            // تنظیمات دیتابیس
            services.AddDbContext<ApiDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            // ثبت کنترلرها
            services.AddControllers();

            // ثبت و فعال‌سازی Swagger (OpenAPI)
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // تنظیمات احراز هویت و هویت سنجی
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
            }).AddEntityFrameworkStores<ApiDbContext>();

            // تنظیمات JWT
            var key = Encoding.ASCII.GetBytes(_configuration["JwtConfig:Secret"]);
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(jwt =>
            {
                jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    RequireExpirationTime = false,
                    ValidateLifetime = false
                };
            });

            // ثبت AutoMapper
            services.AddAutoMapper(typeof(UserProfileMapping));
        }

        // پیکربندی میدلورهای HTTP
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
