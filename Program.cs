using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "hello everyone";
            int mycount = test.Count();
            Console.WriteLine($"num of vowels '{test}' is: {mycount}");


            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");



            Person[] people = new Person[]
            {
                new Person("Gena", "kobachov", 22),
                new Person("Igor", "kobach", 40),
                new Person("Lena", "sler", 60),
                new Person("Kat9", "kivalova", 14),
                new Person("Sasha", "ivanov", 18)
            };

            
            Console.WriteLine($"avarage age: {people.AverageAge()} ");
            Console.WriteLine($"Max age: {people.MaxAge()}");
            Console.WriteLine($"Min age: {people.MinAge()}");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");


            Point3D[] point = new Point3D[]
                {
                    new Point3D(44,213,22),
                    new Point3D(433,512,28),
                    new Point3D(66,95,30),
                    new Point3D(99,55,40),
                    new Point3D(54,69,50),
                    new Point3D(38,22,80),
                    new Point3D(33,15,76)
                };


            

            foreach (var item in point)
            {
                Console.WriteLine($"Point3D: {item.ToString()}");
                
            }
            Console.WriteLine($"Max distance {ForPoint.CalculateMax(point)}");
            Console.WriteLine($"Average Distance: {ForPoint.AverageDistance(point)}");

            Console.WriteLine(" ");

            // вывод для каждой точки
            foreach (var points in point)
            {
                double averageDistance = ForPoint.AverageDistanceToOthers(point, points);
                Console.WriteLine($"Average distance from {point} to all other points: {averageDistance}");
            }
        }
    }
}
