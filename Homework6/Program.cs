using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            string LongestWord = string.Empty;
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > LongestWord.Length)
                {
                    LongestWord = words[i];
                }
            }

            int amount = LongestWord.Length;
            Console.WriteLine("Самое длинное слово в этом предложении это \"{0}\", состоящее из {1} символов", LongestWord, amount);
            Console.ReadKey();

        }
    }
}
