﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 3.Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
              В строке может быть несколько фрагментов, заключённых в фигурные скобки.
              Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.*/
            Console.WriteLine("Введите предложение");
            string S = Console.ReadLine();
            string S1 = Regex.Replace(S, @"\[(.*?)\]", "");
            string S2 = Regex.Replace(S1, @"\(.*?\)", "");
            Console.WriteLine(S2);
            Console.ReadKey();

        }
    }
}
