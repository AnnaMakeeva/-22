using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задание_22
{
    class Program
    {

    
         static void Summa()
         {
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            int Sum = 0;
            
            int[] arr = new int[n];


            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-25, 25);
                Console.Write($"{arr[i]}" + " ");

                Sum += arr[i];

                Thread.Sleep(500);
            }
            //Console.WriteLine("Сумма чисел в массиве: {0}", Sum);
            Console.WriteLine($"/Сумма: {Sum}");

        }
        static void Max(Task a)
         {
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

               int max =0;
                //int i = (int)a;
            
                int[] arr = new int[n];
                for (int i = 0; i < n ; i++)
                {
                arr[i] = random.Next(-25, 25);
                Console.Write($"{arr[i]}" + " ");

                    if (arr[i] > max)
                      max = arr[i];
                    Thread.Sleep(500);
                }
           Console.WriteLine($"/Максимальное число: {max}");
            

            
        }


         static void Main(string[] args)
         {
            //n = Convert.ToInt32(Console.ReadLine());
            //Random rand = new Random();
            //Console.WriteLine("Введите числа массива: ");
            //int n = Convert.ToInt32(Console.ReadLine());


            Action action = new Action(Summa);
            Task task1 = new Task(action);

            Action<Task> actionTask = new Action<Task>(Max);
            Task task2 = task1.ContinueWith(actionTask);

            task1.Start();
            task2.Wait();


            Console.WriteLine("Main закончил работу");

            Console.ReadKey();

         }
    }
} 

