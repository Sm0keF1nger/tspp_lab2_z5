using System;
using System.Security.Cryptography.X509Certificates;

namespace lab2_z3
{
    public class Program
    {


        static public int[,] Massive(int m, int n)
        {
            int[,] b = new int[m, n];
            while (true)
            {
                try
                {

                    Console.WriteLine("Виберіть спосіб розрахунку\n 1: Рандомайзер\n 2: Самостійний ввід даних");
                    string InsertSwitch = Console.ReadLine();
                    int SwitchNum = int.Parse(InsertSwitch);

                    if (SwitchNum != 1 && SwitchNum != 2)
                    {
                        throw new FormatException(); 
                    }

                    switch (SwitchNum)
                    {
                        case 1:


                            Random aRand = new Random();

                            for (int i = 0; i < m; i++)
                            {
                                for (int k = 0; k < n; k++)
                                    {
                                    b[i, k] = aRand.Next(-100, 101);
                                }
                            }
                            break;
                        
                        
                        
                        case 2:
                            while (true)
                            {
                                try
                                {
                                    for (int i = 0; i < m; i++)
                                    {
                                        for (int k = 0; k < n; k++)
                                        {
                                            Console.WriteLine($"Введiть число масива під номером {i + 1} {k + 1}: ");
                                            string insertNum = Console.ReadLine();
                                            int MassNum = int.Parse(insertNum);
                                            b[i, k] = MassNum;
                                        }
                                    }
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Невірно введені дані, спробуйте ще");
                                }
                            }
                            break;
                    }
                break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Невірно введені дані, спробуйте ще");
                }
            
            }

            for (int i = 0; i < m; i++)       
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write($"{b[i, k]} ");
                }
                Console.WriteLine();
            }

            return b;
        }

        static public int SumCalc(int[,] b)
        {
            int sum = 0;
            foreach (int x in b)
            {
                if (x < 0)
                {
                    sum += x;
                }
            }
            if (sum == 0)
                Console.WriteLine("В масивi вiдсутнi вiд'ємнi елементи");
            else
                Console.WriteLine($"Сума від'ємних елементів масиву = {sum}");


            return sum;
        }
      
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Введiть число рядків матриці:");
                    string insertM = Console.ReadLine();
                    int m = int.Parse(insertM);

                    Console.WriteLine("Введiть число колонок матриці:");
                    string insertN = Console.ReadLine();
                    int n = int.Parse(insertN);
                    int[,] array = Massive(m, n);
                    SumCalc(array);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Невірно введені дані, спробуйте ще");
                }
            }


            
            
            Console.ReadLine();
        }
    }
}
