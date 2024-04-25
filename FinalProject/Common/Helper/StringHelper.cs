using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.Helper
{
    public static class StringHelper
    {
        public static string ToMD5(this string input)
        {
            //return input;

            var hash = System.Security.Cryptography.MD5.Create();
            var data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(data);
        }
    }
}
