// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.ForegroundColor = ConsoleColor.DarkGray;
for (int saat = 9; saat < 17; saat++)
{
    if (saat == 12)
        continue;

    for (int dakika = 0; dakika < 46; dakika += 15)
    {
        int sonrakiSaat = saat;
        int sonrakiDakika = dakika + 15;
        if (sonrakiDakika == 60)
        {
            sonrakiSaat++;
            sonrakiDakika = 0;
        }
        Console.WriteLine($"{saat:00}:{dakika:00}-{saat:00}:{dakika + 15:00}");
    }


}
Console.ForegroundColor = ConsoleColor.Green;
DateTime baslangıc = new DateTime(2000, 1, 1, 9, 0, 0);
while (baslangıc.Hour < 17)
{
    DateTime ikinci = baslangıc.AddMinutes(15);
    Console.WriteLine($"{baslangıc:HH:mm}-{ikinci:HH:mm}");
    baslangıc = baslangıc.AddMinutes(15);
    if (baslangıc.Hour == 12)
        baslangıc = baslangıc.AddHours(1);

   

}

Console.ForegroundColor = ConsoleColor.Cyan;
for (DateTime baslangic2 =new DateTime (2000,1,1,9,0,0); baslangic2.Hour < 17; baslangic2=baslangic2.AddMinutes(15))
{

    if (baslangic2.Hour == 12) continue;
    DateTime ikinci = baslangic2.AddMinutes(15);
    Console.WriteLine($"{baslangic2:HH:mm}-{ikinci:HH:mm} ");



}