using System;

namespace helloworld_c_sharp
{
  class Program
  {
    static void Main(string[] args)
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
}
