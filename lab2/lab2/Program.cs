using System;
using System.Linq;

namespace lab2
{
    //Task 1
    public static class StatClass
    {
        public static int Method(this int[] array)
        {
            int min = array.Min();
            int max = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = min;
                }
                else if (array[i] == min)
                {
                    array[i] = max;
                }
            }
            Console.WriteLine($"Максимальний елемент масиву - {max}");
            Console.WriteLine($"Мiнiмальний елемент масиву - {min}");
            return 0;
        }
    }

    //Task 2
    class Search 
    {
        public int year { get; set; }
        public string name { get; set; }
        public int diameter { get; set; }
        public int frequency { get; set; }
        static int count { get; set; }

        public Search(int y, string n, int d, int f)
        {
            this.year = y;
            this.name = n;
            this.diameter = d;
            this.frequency = f;
        }

        public Search[] arr = new Search[10];

        public void Count()
        {
            count = arr.Length;
            Console.WriteLine($"Кiлькiсть об’єктiв: {count}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.Write("Введiть кiлькiсть елементiв масиву: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 50);
            }
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("");
            StatClass.Method(arr);
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("");
            Search search = new Search(0, "", 0, 0);
            for (int i = 0; i < search.arr.Length; i++)
            {
                Console.Write("Рiк: ");
                int year = Convert.ToInt16(Console.ReadLine());
                Console.Write("Науковий керiвник: ");
                string name = Console.ReadLine();
                Console.Write("Дiаметр антени (м): ");
                int diameter = Convert.ToInt16(Console.ReadLine());
                Console.Write("Робоча частота (Мгц): ");
                int frequency = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("");
                search.arr[i] = new Search(year, name, diameter, frequency);
            }
            search.Count();
            Console.WriteLine("");
            int a = 0;
            for (int i = 0; i < search.arr.Length; i++)
            {
                if (search.arr[i].year > 2000)
                {
                    a++;
                }
            }
            if (a > 0)
            {
                Console.WriteLine("Пошук позаземних сигналiв вiдбувся пiсля 2000 року");
            }
            else
            {
                Console.WriteLine("Пошук позаземних сигналiв не вiдбувся пiсля 2000 року");
            }
            Console.WriteLine("");
            if (search.arr.Length < 3)
            {
                Console.WriteLine("Кiлькiсть наявних об'єктiв менше заданих табличних даних у Варiантi №8. Проекти пошуку позаземних сигналiв");
            }
            else if (search.arr.Length > 3)
            {
                Console.WriteLine("Кiлькiсть наявних  об'єктiв перевищує заданi табличнi данi у Варiантi №8. Проекти пошуку позаземних сигналiв");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
