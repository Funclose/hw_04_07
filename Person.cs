using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_07
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public Person(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;
        }
        public override string ToString() => $"Name: {Name}, SurName: {SurName}, Age: {Age}";

        


    }
    public static class ForPerson
    {
        public static int MaxAge(this Person[] people)
        {
            if(people == null || people.Length == 0) return 0;

            Person old = people[0];
            foreach(var item in people)
            {
                if(item.Age > old.Age)
                {
                    old = item;
                }
            }
            return old.Age;
        }

        public static int MinAge(this Person[] people)
        {
            if (people == null || people.Length == 0) return 0;

            Person young = people[0];
            foreach(var item in people)
            {
                if(item.Age < young.Age)
                {
                    young = item;
                }
            }
            return young.Age;
        }

        public static double AverageAge(this Person[] people)
        {
            if (people == null || people.Length == 0) {  return 0; }

            return people.Average(p => p.Age);

        }
    }


}
