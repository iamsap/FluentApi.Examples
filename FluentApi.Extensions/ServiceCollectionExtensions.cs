using System;
using System.Text;
using FluentJwt = FluentApi.Extensions.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace FluentApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static FluentJwt.IJwt AddJwt(this IServiceCollection services){
            return new FluentJwt.Jwt(services);
        }

    }
}
