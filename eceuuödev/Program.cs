using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace eceuuödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // adınızın harflerini for döngüsü ile alt alta sıralayız.

            string isim;
            Console.WriteLine("İsminizi Giriniz:");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isim[i]);
            }
            Console.ReadLine();

            //Aşağıdaki Şekilleri for ile ayrı ayrı oluşturunuz.


            Console.Write("Satır Sayısı Giriniz:");
            int satır = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


            Console.Write("Satır Sayısı Giriniz:");
            int satır1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < satır1; i++)
            {
                for (int j = satır1; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            Console.Write("Satır Sayısı Giriniz:");
            int değer;
            değer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= değer; i++)
            {
                for (int j = değer; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= i; z++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();


            //kullanıcıdan alınacak ürün sayısına göre ürün isimleri istenerek bir diziye atılacak
            //ve sonrasında her bir ürün adı yazılarak karşısında fiyatı istendikten sonra bütün ürünlerin isimleri karşısında fiyatlarını listeleyiniz



            int urunsayısı = 0;
            Console.WriteLine( "Ürün Sayısı Giriniz:");
            urunsayısı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[] urunismi = new string[urunsayısı];
            
            for (int i = 0; i < urunsayısı; i++)
            {
                Console.WriteLine("Ürün Adını Giriniz: ");
                urunismi[i] = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("Fiyat Giriniz:");
                    int fiyat = Convert.ToInt32(Console.ReadLine());
                    break;
                    
                }
            }
            Console.WriteLine();
            int adet = Convert.ToInt32(Console.ReadLine());

        

                Console.ReadLine();

        }
      
       






    }
}
