namespace MethodKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method kullanımı");
            //geriDönüşTipi MethodAdı(parametreTip parametre1,parametreTip parametre2... ) Parantez arasındaki bölüme methodun imzası denmektedir. Method isimleri PascalCase ile yazılmalıdır
            //{
            // return keyword'u metoddan çıkış yapılmasını sağlar.
            // Eğer geri dönüş tipi void değilse o tipte bir değeri method içerisinde return ile döndürmelisiniz. 
            //}
            int sonuc = Topla(2, 3);
            sonuc = Topla(Topla(2, 3), Topla(3, 4));
            sonuc = Topla(1, 2, 3);
            double sonuc2 = Topla(2.2, 3);
            sonuc = Topla(2, 3, 4, 6, 7, 3, 2, 1, 2, 4, 5, 6, 7, 8, 9, 0, 3, 2, 1);
            int sayi = 3;
            KuvvetAl(ref sayi, 3);
            Console.WriteLine(sayi);
            Tuple<bool, int> sonuc3 = TryParse("123");
            if (sonuc3.Item1)
            {
                Console.WriteLine(sonuc3.Item2);
            }
            Console.WriteLine();
        }

        //recursive function
        static int FaktoriyelHesapla(int sayi)
        {
            if (sayi == 1)
                return 1;
            else
                return sayi * FaktoriyelHesapla(sayi - 1);
        }
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        static double Topla(double say1, double say2)
        {
            return say1 + say2;
        }

        static double AlanHesapla(double yaricap, double pi = Math.PI)
        {
            return pi * yaricap * yaricap;
        }

        //ref'li parametreler çağırıldığı yerdeki parametre ile aynı adresi taşıdığından. Method içerisinde yapılan değişiklikler çağırıldığı yerdeki parametreye yansır.

        static void KuvvetAl(ref int sayi, int kuvvet)
        {
            sayi = (int)Math.Pow(sayi, kuvvet);
        }
        //out parametresi
        static bool TryParse(string sayi, out int sonuc)
        {
            try
            {
                sonuc = int.Parse(sayi);
                return true;
            }
            catch (Exception)
            {
                sonuc = 0;
                return false;
            }
        }

        static Tuple<bool, int> TryParse(string sayi)
        {
            try
            {
                int sonuc = int.Parse(sayi);
                return new Tuple<bool, int>(true, sonuc);
            }
            catch (Exception)
            {
                return new Tuple<bool, int>(false, 0);
            }
        }
    }
}