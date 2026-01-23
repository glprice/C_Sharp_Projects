using System;

class CaesarCipher
{
  public static void Run()
  {
    char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
    Console.WriteLine("Insert Message (lowercase only)");

    string msgString =Console.ReadLine();
    char[] secretMessage = msgString.ToCharArray();

    char[] encryptedMessage = new char[secretMessage.Length];

    for (int i=0; i<secretMessage.Length; i++)
    {
      int index = Array.IndexOf(alphabet, secretMessage[i]);
      encryptedMessage[i] = alphabet[(index+3) % alphabet.Length];
    }

    Console.WriteLine(String.Join("", encryptedMessage));
  }
}