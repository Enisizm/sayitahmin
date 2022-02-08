using System;

namespace sayitahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim;
            do
            {
                int sayi, tahmin;

                Console.Write("Sayı Tahmin oyununa hoş geldiniz. (0 - 500) arasında bir sayı giriniz : ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                Random enis = new Random();

                sayi = enis.Next(0, 500);

                do
                {
                    if (sayi > tahmin)
                    {
                        Console.WriteLine("Daha büyük bir sayı giriniz.");
                        tahmin = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (sayi < tahmin)
                    {
                        Console.WriteLine("Daha küçük bir sayı giriniz.");
                        tahmin = Convert.ToInt32(Console.ReadLine());
                    }
                } while (sayi != tahmin);

                Console.WriteLine("Tebrikler Sayıyı Buldunuz. {0}", sayi);

                Console.WriteLine("Tekrar oynamak istiyorsanız 'evet' yazın.");
                secim = Console.ReadLine();
            } while (secim == "evet");

            Console.WriteLine("Oyun Bitti.");
            Console.ReadKey();
        }
    }
}