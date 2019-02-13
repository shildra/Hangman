using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class CWordMgr
    {
        string word;
        int miss_count;
        char[] letterArray;
        List<string> wordList = new List<string>();

        public int getMissCount()
        {
            return miss_count;
        }

        public CWordMgr()
        {
            string url = "word.txt";
            wordList.Clear();

            using (var src = new StreamReader(url))
            {
                string line;
                while ((line = src.ReadLine()) != null)
                {
                    line = line.Replace(" ", string.Empty);
                    wordList.Add(line);
                }

            }
        }
        static Random rnd = new Random();
        public char[] GetWord()
        {            
            int index = rnd.Next(wordList.Count-1);
            string res;
            res = wordList[index];
            word = res;
            miss_count = 0;
            letterArray = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
                letterArray[i] = '*';

            return letterArray;
        }

        public char[] CheckLetter(char letter)
        {
            bool correct = false;
            for (Byte i = 0; i < word.Length; i++)
            {
                if(word[i] == letter)
                {
                    letterArray[i] = letter;
                    correct = true;
                }
            }
            if (!correct)
            {
                miss_count++;
                return null;
            }
            return letterArray;
        }
    }
}