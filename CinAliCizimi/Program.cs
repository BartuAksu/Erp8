using System.Runtime.CompilerServices;

char[,] dotMatrix = new char[60, 60];
for (int i = 0; i < dotMatrix.GetLength(0); i++)
{
    for (int j = 0; j < dotMatrix.GetLength(1); j++)
    {
        dotMatrix[i, j] = ' ';
    }
}

//Kafa Çizimi
KafaCiz();
GovdeCizimi();
Uzuvlar(0);
EkranaYaz();
/*
 * 30,10
 * 40,20
 * 30,30
 * 20,20
 */

void KafaCiz(int x = 10, int y = 10)
{
    int sayac1 = 0;
    for (int i = 10; i >= -10; i -= 2)
    {
        int sayac2 = 20;
        for (int j = -10; j <= 10; j++)
        {
            int hesap = (int)Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
            if (hesap == 10)
            {
                dotMatrix[sayac1, sayac2] = '.';
            }

            sayac2++;
        }
        sayac1++;
    }
}

//Gövde Çizimi

void GovdeCizimi()
{
	for (int i = 0; i < 15; i++)
	{
		dotMatrix[10+i, 30 ] = '.';
	}

}

void Uzuvlar(int param)
{
    // Sağ Kol
    if (Uzuvlar==Helpers.Uzuvlar.Sagol)
        for(int i=0;i<10;i++)
	for (int i = 0; i < 10; i++)
	{
		dotMatrix[10 + i, 30+i] = '.';
	}
    // Sol Kol
    for (int i = 0; i < 10; i++)
    {
        dotMatrix[10 + i, 30 - i] = '.';
    }
    // Sağ Bacak
    for (int i = 0; i < 10; i++)
    {
        dotMatrix[25 + i, 30 + i] = '.';
    }
    // Sol Bacak
    for (int i = 0; i < 10; i++)
    {
        dotMatrix[25 + i, 30-i] = '.';
    }


}






// Ekrana Yaz

void EkranaYaz(bool isClear=true)
{
	if (isClear) Console.Clear();
	for(int i= 0; i<dotMatrix.GetLength(0);i++)
	{
		for (int j = 0; j < dotMatrix.GetLength(1); j++)
		{
			Console.Write(dotMatrix[i,j]);
		}

	}
	
}

