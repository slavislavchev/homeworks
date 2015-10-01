using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string repeatedWord = Console.ReadLine();
                        for (int i = 0; i < repeatedWord.Length-1; i++)
                        {
                            if (repeatedWord[i] != repeatedWord[i + 1])
                            {
                                Console.Write(repeatedWord[i]);
                            }
                        }
                        if (repeatedWord.Last() != repeatedWord.Length - 1)
                        {
                            Console.WriteLine(repeatedWord.Last());
                        }
                    }
        }
}

