using System;
using System.Text;
using System.Security.Cryptography;

namespace HelloWorldCSharp
{
    public class SampleSha256Encryption
    {
        public static void Run()
        {
            // 이메일 주소에서 아이디와 도메인 분리
            string email = "user01@test.co.kr";
            int emailIndex = email.IndexOf("@");
            string emailId = email.Substring(0, emailIndex);
            Console.WriteLine(emailId);

            // sha256 to base64 sample
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