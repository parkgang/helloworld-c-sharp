using System;

namespace HelloWorldCSharp
{
    /// <summary>
    /// 이메일 주소에서 아이디와 도메인 분리
    /// </summary>
    public class SampleEmailIdDomainSeparation
    {
        public static void Run()
        {
            string email = "user01@test.co.kr";
            int emailIndex = email.IndexOf("@");
            string emailId = email.Substring(0, emailIndex);
            Console.WriteLine(emailId);
        }
    }
}