using System;

namespace tugasRPLMenuMakanan
{
    internal class main
    {
        static void Main(string[] args)
        {
            // User masukan Inputan Makanan

            string? inputUser;

            Console.Write("\nFarian : Rendang, Gudeg, Sate, Rawon, Serabi\n\nMasukan Nama Makanan : ");
            inputUser = Console.ReadLine();

            // Logika
            switch (inputUser)
            {
                case "rendang":
                    Console.WriteLine("Makanan Habis");
                    break;

                case "gudeg":
                    Console.WriteLine("Makanan Tersedia");
                    break;

                case "sate":
                    Console.WriteLine("Makanan Tersedia");
                    break;

                case "rawon":
                    Console.WriteLine("Makanan Tersedia");
                    break;

                case "serabi":
                    Console.WriteLine("Makanan Habis");
                    break;
                default:
                    Console.WriteLine("Makanan tidak ada");
                    break;
            }
        }
    }
}
