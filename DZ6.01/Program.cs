using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложениие : ");
            string s = Console.ReadLine();
            string wordWithMaxLength = string.Empty;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > wordWithMaxLength.Length)
                    wordWithMaxLength = words[i];
            Console.WriteLine("Самое длинное слово в предложении : " + wordWithMaxLength);
            string[] words1 = s.Split(' ');
            int max = 0;
            for (int i = 0; i < max; i++)
            {

            }
            if (words1.Length > max)
                max = words1.Length;
            Console.WriteLine("Всего слов в предложении : " + max);
            string revs = "";
            s = s.Replace(" ", "");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("Данный текст является полиндромом ", revs);
            }
            else
            {

                Console.WriteLine("Данный текст не является полиндромом ", revs);
            }
            Console.ReadKey();
        }
    }
}
