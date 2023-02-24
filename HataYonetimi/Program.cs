// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Hata Yönetimi
 * 1)Kullanıcı giriş işlemlerinde
 * 2)Dosya İşlemlerinde
 * 3)Ağ İşlemlerinde
 * 4)Veritabanı İşlemlerde
 * 5)Matematiksel İşlemlerde
 * 6)Programın çalışma zamanında oluşabilecek hatalarda
 * Kullanılmalıdır
 */

using System.Reflection.Metadata;

Console.WriteLine("0 ile 10 arasında bir sayı giriniz");
int hak= 3;
do
{

    try
    {


        int girilenSayı = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Girdiğiniz sayı: {girilenSayı}");
        if (girilenSayı < 0 || girilenSayı > 10)
        {
            throw new Exception(message: "Girilen sayı 0 ile 10 arasında olmalıdır");
        }

        Console.WriteLine($"Girdiğiniz sayı:{girilenSayı}");
        break;

    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
        hak--;
    }

    finally // bu blok her durumda çalışır. Hata olsa da olmasa da
    {
        Console.WriteLine("işlem tamamlandı");
    }
} while (hak > 0);
    if (hak > 0)
        Console.WriteLine("Aferin başarabildin");
    else
        Console.WriteLine("Başaramadın:(");

    Console.WriteLine("Bir sayı daha girin");
    string giris = Console.ReadLine();
    if (int.TryParse(giris, out int sayi))
    {
        Console.WriteLine("Girdiğiniz sayı:" + sayi);
    }
    else
    {
        Console.WriteLine("Sayı girmeyi beceremedin");
    }

