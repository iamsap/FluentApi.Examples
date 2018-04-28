using System;
namespace FluentApi.Extensions.Jwt
{
    public interface IJwt
    {
        IJwt WithIssuer(string issuer);
        IJwt WithAudience(string audience);
        IJwt WithKey(string key);

        void Apply();
    }
}
