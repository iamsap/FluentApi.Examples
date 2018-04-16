using System;
using Microsoft.Extensions.DependencyInjection;

namespace FluentApi.Extensions
{
    public class Startup
    {
        /**
        public void Configure(IServiceCollection services){
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = "https://angular-azure1.auth0.com/",
                    ValidAudience = "api://forecasts",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6sJcIDp0ok2yNioISK1E0gAZHp63YB13"))
                };
            });
        }
         */

        public void Configure(IServiceCollection services){
            //services.AddJwt()
                    //.WithIssuer("issuer")
                    //.WithAudience("audience")
                    //.WithKey("key");
        }
    }
}
