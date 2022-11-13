using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BaltikaApp
{
    internal class DBoperation
    {
        public string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes(password));

                string hashstring = BitConverter.ToString(hash);

                return hashstring;
            }
        }
    }
}
