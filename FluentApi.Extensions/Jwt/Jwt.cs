using System;
namespace FluentApi.Extensions.Jwt
{
    public class Jwt : IJwt
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Key { get; set; }
        
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
    }
}
