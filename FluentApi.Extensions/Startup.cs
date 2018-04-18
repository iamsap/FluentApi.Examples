using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace FluentApi.Extensions
{
    public class Startup
    {
        const string Issuer = "<<Issuer>>";
        const string Audience = "<<Audience>>";
        const string SigningKey = "<<Key>>";

        public void AddJwt(IServiceCollection services){
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = Issuer,
                    ValidAudience = Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SigningKey))
                };
            });
        }

        public void AddJwtFluent(IServiceCollection services){
            services.AddJwt()
                    .WithIssuer(Issuer)
                    .WithAudience(Audience)
                    .WithKey(SigningKey);
        }
    }
}
