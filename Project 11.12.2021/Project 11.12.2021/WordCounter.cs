using System;
using System.Collections.Generic;
using System.Text;

namespace Project_11._12._2021
{
    class WordCounter
    {
        public string Word;
        public WordCounter(string word)
        {
            int counter = 1;
            Word = word;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine("Total number of words in the string is : " + counter);

        }
    }
}
