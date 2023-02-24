// Karar yapıları ve döngüler
using System.Globalization;

//if (kosul)
//{
//  işlemler
//}
//else if (kosul)
//{
//    işlemler
//}
//else
//{
//    işlemler
//}

//switch (degisken)
//{
//	case deger1:
//		işlemler
//			break;
//	case deger2:
//		işlemler
//			break;
//}

//while (kosul)
//{
//    işlemler
//}

//do
//{
//işlemler
//} while (kosul);

//for (int i = 0; i < length; i++)
//{
//    işlemler
//}
//foreach (var item in collection)
//{
//işlemler
//}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    i--;
}

while (true)
{
    Console.WriteLine(DateTime.Now);
    if (DateTime.Now.Minute == 15)
        break;
}

int sayi2 = 324;
if (sayi2 %2==0)
    Console.WriteLine("Çift");
else
    Console.WriteLine("Tek");

string sonuc= sayi2 % 2==0 ? "Çift" : "Tek"; // Ternary-if

Console.WriteLine(sayi2 % 2== 0 ? "Çift" : "Tek");

Random rnd;

//rnd.Next(100);

if (rnd == null)
    rnd = new Random();

sayi2 = sayi2 + 1;
sayi2 += 1;

rnd = rnd ?? new Random();
rnd ??= new Random();

//// String methotlar
//   Math Methodlar
//   DateTime Methodlar




