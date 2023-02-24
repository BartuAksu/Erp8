//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//// Dizi aynı tipteki değişkenleri ya da verileri bir arada tutabildiğimiz bir yapıdır.
//int[] sayılar = new int[5];

//int[] sayılar2 = new[] { 1, 5.6, 3, 2 };

//for (int i = 0; i < sayilar2.Length; i++)
//{
//    Console.WriteLine(sayilar2[i]);

//}

//foreach (var sayi in sayilar2)
//{
//    Console.WriteLine(sayi);
//}
//Console.Clear();
//string cumle = "dizi aynı tipteki değişkenleri ya da verileri bir arada tutabildiğimiz bir yapıdır.";

//string[] kelimeler = cumle.Split(' ');
//foreach (var kelime in kelimeler)
//{
//    Console.WriteLine(kelime);
//}

//sayilar[]
//sayilar[1] = 4;
//sayilar[2] = 3;
//sayilar[3] = 2;
//sayilar[4] = 1;
//sayilar[5] = 0;

//Random rnd = new Random();

//for (int i = 0; i < sayilar.Length; i++)
//{
//    sayilar[i] = rnd.Next(1, 100);
//}

//Console.WriteLine(sayilar[rnd.Next(sayilar.Length)]);

//Console.Clear();

// 1-49 arasında 6 tane benzersiz sayı diziye dolduran kod  parçası

using System.Collections;
using System.Linq;

int[] secimler = new int[6];
Random rnd = new Random();
for (int i = 0; i < secimler.Length; i++)
{
    int sayi = rnd.Next(1, 50);
    //int index = Array.IndexOf(secimler, sayi);
    //if (index == -1)
    //    secimler[i] = sayi;
    //else
    //    i--;
    if (secimler.Contains(sayi))

        i--;
    else
        secimler[i] = sayi;
}

Console.WriteLine();

Array.Resize(ref secimler, 10);

object a = 1;
object b = "Kamil";
object c = DateTime.Now;

object[] objeler = new object[3];
objeler[0] = a;
objeler[1] = b;
objeler[2] = c;

ArrayList liste = new ArrayList();
liste.Add(a);
liste.Add(b);
liste.Add(c);

List<int> sayilar3 = new List<int>();
sayilar3.Add(1);
sayilar3.Add(2);
sayilar3.Add(3);
sayilar3.Add(4);

sayilar3.Where(x=>  x > 18 && x < 25).ToList();

