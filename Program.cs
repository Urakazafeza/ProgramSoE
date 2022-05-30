using System;
public class Program
{
    static int[] Primes = new int[1000];
    static void SieveErato (int n)
    {
        Primes[0] = 1;
        for (int i = 3; i*i <= n; i+=2)
        {
            if (Primes[i/2] == 0)
            {
                for (int j = 3 * i; j <= n; j += 2 * i)
                    Primes[j / 2] = 1;
            }
        }
    }
    public static void Main (string[] args)
    {
        int p = 100;
        SieveErato (p);
        for (int i = 0; i < p; i++)
        {
            if (i == 2)
                Console.Write(i + "");
            else if (i % 2 == 1 && Primes[i / 2] == 0)
                Console.Write(i + "");
        }
    }
}