using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography; // <---------
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceWithDatabaseAccess.Utilities.Security {
    public class Cryptography {
        public string Hash { get; set; }
        public string Salt { get; set; }

        public static Cryptography GenerateSaltedHash(int size, string password) {
            var saltBytes = new byte[size];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            var salt = Convert.ToBase64String(saltBytes);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            Cryptography hashSalt = new Cryptography { Hash = hashPassword, Salt = salt };
            return hashSalt;
        }
    }
}
