using System;
using System.Security.Cryptography;
using System.Text;

namespace HelloWorldCSharp
{
    public class EncryptionHelper
    {
        public static string EncryptionSHA256(string password)
        {
            // sha256
            var sha256Managed = new SHA256Managed();
            byte[] encryptBytes = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password));

            // base64
            string encryptString = Convert.ToBase64String(encryptBytes);

            return encryptString;
        }
    }
}