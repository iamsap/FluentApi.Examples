using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace FluentApi.Extensions.Jwt
{
    public class Jwt : IJwt
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Key { get; set; }
        private IServiceCollection _services;

        public Jwt(IServiceCollection services){
            _services = services;
        }

        public IJwt WithAudience(string audience)
        {
            Audience = audience;
            return this as IJwt;
        }

        public IJwt WithIssuer(string issuer)
        {
            Issuer = issuer;
            return this as IJwt;
        }

        public IJwt WithKey(string key)
        {
            Key = key;
            return this as IJwt;
        }

        public void Apply() 
        {
            _services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = Issuer,
                    ValidAudience = Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key))
                };
            });

        }
    }
}
