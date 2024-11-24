using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace HPlusSport.Security.Web.Classes
{
    public class PasswordHelper
    {
        private const int numberOfIterations = 310000;
        private static readonly HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA3_256;



        public static HashInformation HashPassword(string password)
        {
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(
                password, 32, numberOfIterations, hashAlgorithm);
            var hash = rfc2898DeriveBytes.GetBytes(20);
            var salt = rfc2898DeriveBytes.Salt;

            return new HashInformation(
                Convert.ToBase64String(hash),
                Convert.ToBase64String(salt)
                );

        }

        public static bool VerifyPassword(string password, HashInformation hashInformation)
        {
            var salt = Convert.FromBase64String(hashInformation.Salt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, 32, numberOfIterations, hashAlgorithm);
            var hash = rfc2898DeriveBytes.GetBytes(20);

            return Convert.ToBase64String(hash) == hashInformation.Hash;
        }



        public record HashInformation(string Hash, string Salt);
    }
}
