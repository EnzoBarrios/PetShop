using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetShop.Negocio
{
    public static class SeguridadHelper
    {
        public static string GenerarHashSha256(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return string.Empty;
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static bool EsHashSha256(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || valor.Length != 64)
                return false;

            return Regex.IsMatch(valor, @"\A\b[0-9a-fA-F]+\b\Z");
        }
    }
}
