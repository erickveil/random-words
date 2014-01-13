using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomWords
{
    class WordGen
    {
        private String[] consonants={"b","c","d","f","g","h","j","k","l","m","n","p","r","s","t","v","w","x","y","z","th","ch","qu"};
        private String[] vowels={"a","e","i","o","u","ae","ai","ao","au","ea","ee","ei","eo","eu","ia","ie","io","oa","oe","oi","oo","ou","ua","uu"};
        private const int MAX_LENGTH=3;

        public WordGen()
        {

        }

        public String randSyllable(Random gen)
        {
            String syl="";
            int first_place = gen.Next(0, consonants.Length);
            int second_place = gen.Next(0, vowels.Length);
            int third_place = gen.Next(0, consonants.Length);

            syl += consonants[first_place];
            syl += vowels[second_place];
            syl += consonants[third_place];

            return syl;
        }

        public String randWord(Random gen)
        {
            int word_length = gen.Next(1, MAX_LENGTH);
            String new_word = "";

            for (int i = 0; i < word_length; ++i)
            {
                new_word += randSyllable(gen);
            }

            return new_word;
        }
    }
}
