using System;
using System.Text;
using System.Security.Cryptography;

namespace HelloWorldCSharp
{
    /// <summary>
    /// 비밀번호를 sha256 으로 암호화 후 base64로 인코딩하는 예제입니다.
    /// </summary>
    public class SampleSha256Encryption
    {
        public static void Run()
        {
            Console.Write("패스워드를 입력해주세요: ");
            string password = Console.ReadLine();
            string encrypt = EncryptionHelper.EncryptionSHA256(password);
            Console.WriteLine($"base64: {encrypt}");
        }
    }

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