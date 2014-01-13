using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomWords
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            WordGen newWord = new WordGen();
            System.Console.WriteLine( newWord.randWord(rand) );
        }
    }
}
