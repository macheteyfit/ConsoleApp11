using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using static ConsoleApp11.Program;

namespace ConsoleApp11
{
    internal class Program
    {
        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Cat : Animal
        {
            // Add any cat-specific properties here if needed
        }

        public class Dog : Animal
        {
            // Add any dog-specific properties here if needed
        }

        static void Print()
        {
            Console.WriteLine("Hello Thraeads");
        }

        static void PrintNumbers()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Второй поток: {i}");
                Thread.Sleep(20);
             
            }
        }

        static void PrintWithDelay(int i)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Task {i} Finished");
        }

        
        static void Main(string[] args)
        {
            //Thread currentThread = Thread.CurrentThread;

            //currentThread.Name = "Метод Main";

            //Console.WriteLine($"Имя потока: {currentThread.Name}");

            //Console.WriteLine($"Запущен ли поток: {currentThread.Name}");
            //Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
            //Console.WriteLine($"Статус потока: {currentThread.ThreadState}");

            //Console.WriteLine("\n---------------------------\n");

            //Thread currentThread2 = new Thread(() => { });
            //currentThread2.Name = "Второй поток";

            //Console.WriteLine($"Имя потока: {currentThread2.Name}");

            //Console.WriteLine($"Запущен ли поток: {currentThread2.Name}");
            //Console.WriteLine($"Приоритет потока: {currentThread2.Priority}");
            //Console.WriteLine($"Статус потока: {currentThread2.ThreadState}");

            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(20);
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("\n---------------------------\n");

            //Thread myThread1 = new Thread(Print);
            //Thread myThread2 = new Thread(new ThreadStart(Print));
            //Thread myThread3 = new Thread(() => Console.WriteLine("Hello Threads"));

            //myThread1.Start();
            //myThread2.Start();
            //myThread3.Start();

            //for (int j = 0; j < 10; j++)
            //{
            //    Thread.Sleep(20);
            //    Console.WriteLine(j);
            //}

            //Console.WriteLine("\n---------------------------\n");

            //Thread myThread = new Thread(PrintNumbers);
            //myThread.Start();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Второй поток: {i}");
            //    Thread.Sleep(20);
            //}

            //Console.WriteLine("\n---------------------------\n");

            //Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
            //task1.Start();

            ////Task task1 = new Task(() => {
            ////    Thread.Sleep(200);
            ////    Console.WriteLine("Task1 is executed");
            ////});
            ////task1.Start();

            //Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));

            //Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));

            //Console.WriteLine("\n---------------------------\n");

            //task1.Wait();
            //task2.Wait();
            //task3.Wait();

            //Console.WriteLine("\n---------------------------\n");

            //PrintWithDelay(4);
            //PrintWithDelay(5);
            //PrintWithDelay(6);

            //Task task4 = Task.Run(() => { PrintWithDelay(4); });
            //Task task5 = Task.Run(() => { PrintWithDelay(5); });
            //Task task6 = Task.Run(() => { PrintWithDelay(6); });


            //task4.Wait();
            //task5.Wait();
            //task6.Wait();

            //Console.WriteLine("\n---------------------------\n");

            //long size = 200000000;
            //int[] numbers = new int[size];
            //Random rand = new Random();
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = rand.Next(0, 10);
            //}

            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    sum += numbers[i];
            //}

            //sw.Stop();
            //Console.WriteLine((double)sw.ElapsedMilliseconds / 10000);
            //Console.WriteLine("\n---------------------------\n");


            
            Animal[] animal =
            {
                new Cat() { Name="Cat1", Age=2 },
                new Cat() { Name="Cat2", Age=6 },
                new Cat() { Name="Cat3", Age=4 },
                new Dog() { Name="Bobik", Age=5 },
                new Dog() { Name="Tubik", Age=7 },
                new Dog() { Name="Sharic", Age=1 },
            };
            var cats = animal.OfType<Cat>();
            var dogs = animal.OfType<Dog>();

            var averageCatAge = cats.Average(cat => cat.Age);
            var averageDogAge = dogs.Average(dog => dog.Age);

            Console.WriteLine($"Average cat age: {averageCatAge}");
            Console.WriteLine($"Average dog age: {averageDogAge}");

            // Age > 5 name have 2

            var animalFiltered = animal.Where(a =>
               a.Name.Contains('2') || a.Age > 5
           );

            
            foreach (var animals in animalFiltered)
            {
                Console.WriteLine($"Name: {animals.Name}, Age: {animals.Age}");
            }



            Console.ReadKey();
        }
      
    }
}
