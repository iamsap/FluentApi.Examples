using System;
using System.Text;
using FluentApi.Extensions.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace FluentApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IJwt AddJwt(this IServiceCollection services){
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

            return new FluentApi.Extensions.Jwt.Jwt();
        }

    }
}
