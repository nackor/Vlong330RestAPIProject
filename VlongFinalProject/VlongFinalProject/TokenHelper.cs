using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Text;

namespace VlongFinalProject
{
    public class TokenHelper
    {
       
        public static string Tokenize(string password)
        {
            byte[] salt = Encoding.ASCII.GetBytes("victor");
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password!,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

            return hashed;
        }

    }   
}
