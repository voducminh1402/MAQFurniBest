using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAQFurni.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MAQFurni
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
            services.AddDbContext<FurnitureShopContext>(options =>
            {
                // Đọc chuỗi kết nối
                string connectstring = Configuration.GetConnectionString("FurnitureShop");
                // Sử dụng MS SQL Server
                options.UseSqlServer(connectstring);
            });

            services.AddDefaultIdentity<User>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<FurnitureShopContext>()
            .AddDefaultTokenProviders();
            services.AddOptions();                                         // Kích hoạt Options
            var mailsettings = Configuration.GetSection("MailSettings");  // đọc config
            services.Configure<MailSetting>(mailsettings);                // đăng ký để Inject
            services.AddTransient<ISendMailService, SendMailService>();
            services.Configure<IdentityOptions>(options =>
            {
                // Thiết lập về Password
                options.Password.RequireDigit = false; // Không bắt phải có số
                options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
                options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
                options.Password.RequireUppercase = false; // Không bắt buộc chữ in
                options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
                options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt

                // Cấu hình Lockout - khóa user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa 5 phút
                options.Lockout.MaxFailedAccessAttempts = 5; // Thất bại 5 lầ thì khóa
                options.Lockout.AllowedForNewUsers = true;

                // Cấu hình về User.
                options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;  // Email là duy nhất

                // Cấu hình đăng nhập.
                options.SignIn.RequireConfirmedEmail = true;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
                options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại

            });

            services.ConfigureApplicationCookie(options =>
            {
                // options.Cookie.HttpOnly = true;  
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = $"/login/";                                 // Url đến trang đăng nhập
                options.LogoutPath = $"/logout/";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";   // Trang khi User bị cấm truy cập
            });
            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                // Trên 5 giây truy cập lại sẽ nạp lại thông tin User (Role)
                // SecurityStamp trong bảng User đổi -> nạp lại thông tinn Security
                options.ValidationInterval = TimeSpan.FromSeconds(5);
            });
            services.AddAuthentication()
    .AddGoogle(googleOptions =>
    {
        // Đọc thông tin Authentication:Google từ appsettings.json
        IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");

        // Thiết lập ClientID và ClientSecret để truy cập API google
        googleOptions.ClientId = googleAuthNSection["ClientId"];
        googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
        // Cấu hình Url callback lại từ Google (không thiết lập thì mặc định là /signin-google)
        googleOptions.CallbackPath = "/login-with-google";

    });
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();

                endpoints.MapGet("/chec-out-success", async context =>
                {
                    // Lấy dịch vụ sendmailservice
                    var sendmailservice = context.RequestServices.GetService<ISendMailService>();

                    MailContent content = new MailContent
                    {
                        To = "honganhle00@gmail.com",
                        Subject = "Thank you!",
                        Body = $"Thank you for your order"
                    };

                    await sendmailservice.SendMail(content);
                });
            });
        }
    }
}
