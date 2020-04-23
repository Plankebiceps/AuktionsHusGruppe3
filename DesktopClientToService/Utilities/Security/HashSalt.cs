using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography; // <---------
using System.Text;
using System.Threading.Tasks;

namespace DesktopClientToService.Utilities.Security {

    public class HashSalt {

        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt) {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == storedHash;
        }
    }
}
