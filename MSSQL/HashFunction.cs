using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL
{
    class HashFunction
    {
        public static string HashPassword (string password)
        {
            SHA256 sha256 = SHA256.Create ();
            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = sha256.ComputeHash (b);

            StringBuilder sb = new StringBuilder ();
            foreach (byte b2 in hash)
                sb.Append (b2.ToString("X2"));

            return Convert.ToString(sb);
        }
    }
}
