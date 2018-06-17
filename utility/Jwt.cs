using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace Utility
{
    public class Jwt
    {
        public static RsaSecurityKey Key { get; } = new RsaSecurityKey(RSAKeyHelper.GenerateKey());
        public static SigningCredentials SigningCredentials { get; } = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
    }

    public class RSAKeyHelper
    {
        public static RSAParameters GenerateKey()
        {
            using (var key = new RSACryptoServiceProvider(2048))
                return key.ExportParameters(true);
        }
    }
}
