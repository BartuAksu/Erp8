//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello World");

//// Tamsayı değişken tiperi

//byte degiskenByte = 2;
//short degiskenShort = 5;
//ushort degiskenUShort = 4;
//int degiskenİnt = 0;

//// ondalıklı değişken tipleri

//double degiskenDouble = 0.5;
//float degiskenFloat = 0.5f;
//decimal degiskenDecimal = 0.5m;

//degiskenİnt = 1_999_999;
//degiskenİnt = 0b101010110;
//degiskenİnt = 0x123af21c;
//Console.WriteLine(degiskenİnt);

//int sonuc = 9 / 3;
//sonuc = Convert.ToInt32(5 / 2d);
//Console.WriteLine(sonuc);

////Aritmatik operatörler
//// + - * / %

//int a = 5;

//int b = 10;

//a = b++;
//Console.WriteLine(a);
//Console.WriteLine(b);
//a = a + 10;
//a += 10;

//a = a % 2;
//a %= 2;

////

//char karakter = 'a';
//karakter = '\u006A';
//Console.WriteLine(karakter);

//string kelime = "Merhaba Dünya";
//char[] kelimeDizi = new[] { 'M', 'e', 'r' };

//char harf = kelime[1];

//Console.WriteLine(kelimeDizi[2]);
//Console.WriteLine(kelime[2]);

//// Mantıksal tip
//bool dogruMu = true;

//// Mantıksal operatörler

//// > < => = != ! işlem &&   ||

////
//dogruMu = degiskenİnt > degiskenDouble;
//Console.WriteLine(dogruMu);
//dogruMu = degiskenShort < degiskenİnt && kelime.Length > 10;

//bool tekmMi = a % 2 ==1;
//Console.WriteLine("İşlemin sonucu:" + (5 + 6 + 9));
//Console.WriteLine(tekmMi.ToString());
//Console.WriteLine(tekmMi);

//Console.BackgroundColor = ConsoleColor.DarkMagenta;

//Console.CursorSize = 14;

//Console.WriteLine();


//for (int i=0; i<30; i++) { 

//DateTime simdi = DateTime.Now;
//Console.WriteLine(simdi.Hour.ToString(format:"00") + ":" + simdi.Minute.ToString(format:"00") + ":" + simdi.Second.ToString(format:"00"));

//Console.WriteLine($"{simdi.Hour:00}:{simdi.Minute:00}:{simdi.Second:00}");
//Console.WriteLine($"{simdi:dd:MM:yyyy  -  HH:mm:ss}");

//Thread.Sleep(millisecondsTimeout: 1000);
//Console.Clear();
//}

////escape sequances

///*
// *\n newLine
// *\t tab
// *\b backSpace
// *\\
// *@
// */

//kelime = " Bu hikayenin çok uzun bir kısmını \n metin\" karşılamaktadır.";
//string path =@"c:\dosyalar\falan.txt";
//Console.WriteLine(kelime);


