using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a project:");
        Console.WriteLine("1 - Caesar Cipher");
        Console.WriteLine("2 - Space Mission Inventory");
        Console.WriteLine("3 - True or False");

        string choice = Console.ReadLine();

        if (choice == "1")
            CaesarCipher.Run();
        else if (choice == "2")
            SpaceMissionInventory.Run();
        else if (choice == "3")
            TrueOrFalse.Run();
    }
}

