using System;
using vigenère_verschlüsselungO;

namespace vigenère_verschlüsselung
{
    internal class Program
    {
        static void Main(string[] args)
       {
            Verschluessung vigenère_verschl = new Verschluessung();
            Console.WriteLine("input Text");
            vigenère_verschl.clearText = Console.ReadLine();
            Console.WriteLine("input Key");
            vigenère_verschl.key = Console.ReadLine();
            Console.WriteLine(vigenère_verschl.codedText);



        }
    } 
}