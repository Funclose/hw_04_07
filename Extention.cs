using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Завдання 4
//Створіть метод розширення (extension method) для 
//підрахунку кількості голосних у рядку. Напишіть код для 
//тестування методу
namespace hw_04_07
{
    internal static class Extention
    {
        public static int Count(this string value)
        {
            if(string.IsNullOrEmpty(value)) return 0;

            int count = 0;
            char[] el = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char c in el)
            { 
                if(Array.IndexOf(el, c) >= 0) count++;
            }
            return count;

        }
    }
}
