using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_txt
{
    struct FirstCharacter
    {
                            
    }

    struct MiddleCharacter
    {

    }

    struct LastCharacter
    {

    }

    class MarkovWordGenerator
    {
        FirstCharacter[] firstCharacters = new FirstCharacter[26];
        MiddleCharacter[] middleCharacters = new MiddleCharacter[26];
        LastCharacter[] lastCharacters = new LastCharacter[26];

        public void Addword(string word)
        {
            if (word.Length > 3)
            {
                AddFirstCharacters();
                AddMiddleCharacters();
                AddEndCharacters();
            }
                    

        }

        private void AddFirstCharacters()
        {
            throw new NotImplementedException();
        }

        private void AddMiddleCharacters()
        {
            throw new NotImplementedException();
        }

        private void AddEndCharacters()
        {
            throw new NotImplementedException();
        }
    }
}
