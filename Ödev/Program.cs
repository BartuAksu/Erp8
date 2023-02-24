
//int sayac = 0;
//int tahmin = 0;
//int hafiza;
//Random rastgele = new Random();
//hafiza = rastgele.Next(1, 100);
//while (tahmin != hafiza)
//{
//    sayac++;
//    Console.WriteLine("Bir Sayı Giriniz");
//    tahmin = Convert.ToInt16(Console.ReadLine());

//    if (tahmin > hafiza)
//    {
//        Console.WriteLine("Daha Kücük Bir Sayı Giriniz");
//    }
//    else if (tahmin < hafiza)

//    {
//        Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
//    }


//}
//Console.WriteLine("Tebrikler");
//Console.WriteLine("{0}. deneme de buldunuz", sayac);

//using System.Xml;


//Console.WriteLine("1 ile 6 arasında sayı giriniz:");
//int girilenSayi = Convert.ToInt32(Console.ReadLine());

//int sayac = 0;
//Random rastgele = new Random();

//for (int i = 1; i > 0; i++)
//{
//    sayac++;
//    int zar1 = rastgele.Next(1, 7);
//    Console.Write(zar1 + " ");
//    int zar2 = rastgele.Next(1, 7);
//    Console.WriteLine(zar2);

//    if (zar1 == girilenSayi && zar2 == girilenSayi)
//    {

//        Console.WriteLine(sayac + ". zar eşit geldi " + zar1 + "-" + zar2);

//        break;

//    }
//}
//Console.WriteLine();


//using System.Xml.Serialization;

//int sayi, basamak;
//string[,] yazi = new string[10, 4] { { "sıfır", "", "", "" }, { "bir", "on", "yüz", "bin" }, { "iki", "yirmi", "ikiyüz", "ikibin" },
//    { "üç", "otuz", "üçyüz", "üçbin" }, { "dört", "kırk", "dörtyüz", "dörtbin" }, { "beş", "elli", "beşyüz", "beşbin" } ,
//    { "altı", "atmış", "altıyüz", "altıbin" },{ "yedi", "yetmiş", "yediyüz", "yedibin" },{ "sekiz", "seksen", "sekizyüz", "sekizbin" },
//    { "dokuz", "doksan", "dokuzyüz", "dokuzbin" }};
//Console.WriteLine("Bir sayi giriniz:");
//sayi = Convert.ToInt32(Console.ReadLine());
//basamak = Convert.ToString(sayi).Length;
//if (basamak == 4)
//    Console.Write(yazi[sayi / 1000 % 10, 3] + " ");
//if (basamak >= 3)
//    Console.Write(yazi[sayi / 100 % 10, 2] + " ");
//if (basamak >= 2)
//    Console.Write(yazi[sayi / 10 % 10, 1] + " ");
//if (basamak >= 1)
//    Console.Write(yazi[sayi % 10, 0] + " ");
/////////////////////////////////////////////////////////////////////////////////////////////

bool devamMi = true;

do
{ 
  case"1":
        //SayiTahminOyunu();
        break;
  case"2":
        //ZarTehminEtmeOyunu();
        break;
  case"3":
            //SayiyiMetneCevir();
            break;
  case   "4":  
        //devamMi= false;
        devamMi = !devamMi;
    break;

} while (devamMi);

Console.WriteLine("Program sonandı.");

void SayiTahminOyunu()
{
    int sayi = new Random().Next(1, 101);
    int tahminSayisi = 0;
    do
    {
        Console.WriteLine("0-100 arası bir sayı giriniz");
        tahminSayisi++;
        try
        {

            int tahminEdilenSayi = int.Parse(Console.ReadLine());
            if (tahminEdilenSayi < 0 || tahminEdilenSayi > 100)
                throw new Exception("0-100 arası bir sayı giriniz.");
            if (tahminEdilenSayi < sayi)
                Console.WriteLine("Daha büyük bir sayı giriniz.");
            else if (tahminEdilenSayi > sayi)
                Console.WriteLine("Daha Büyük bir sayı giriniz.");
            else
            {
                Console.WriteLine($"Tebrikler, {tahminSayisi}adet denemede doğru tahmin ettiniz.");
                break;
            }
        }
        catch (Exception)
        {

            throw;
        }
    } while (true);

}


