using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.    Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
            Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра.*/

            string sentence = Console.ReadLine();

            sentence = sentence.Replace(" ", "").ToLower();
            
            string reverse = new string(sentence.ToCharArray().Reverse().ToArray());

            if (sentence == reverse)
            {
                Console.WriteLine("Полидром");
            }
            else
            {
                Console.WriteLine("Не полидром");
            }
            Console.ReadKey();





        }
    }
}
