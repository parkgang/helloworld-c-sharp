using System;

namespace helloworld_c_sharp
{
  class Program
  {
    static void Main(string[] args)
    {
      // sha256 to base64 sample
      Console.Write("패스워드를 입력해주세요: ");
      string password = Console.ReadLine();
      string encrypt = EncryptionHelper.EncryptionSHA256(password);
      Console.WriteLine($"base64: {encrypt}");
    }
  }
}
