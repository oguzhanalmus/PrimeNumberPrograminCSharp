using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        int n, i, m = 0, flag = 0;
        Console.Write("Kontrol edilecek sayıyı giriniz");
        n = int.Parse(Console.ReadLine());
        m = n / 2;
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.Write("Sayı asal değil");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("Sayı asaldır");
    }
}