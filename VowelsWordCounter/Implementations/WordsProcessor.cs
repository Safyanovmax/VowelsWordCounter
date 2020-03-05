using System.Collections.Generic;
using VowelsWordCounter.Interfaces;

namespace VowelsWordCounter.Implementations
{
    public class WordsProcessor : IWordsProcessor
    {
        private readonly HashSet<char> _vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        public int GetVowelsCount(List<string> words)
        {
            var wordsOfVowelsCounter = 0;

            foreach (string word in words)
            {
                var lowWord = word.ToLower();
                var vowelCounter = 0;

                foreach (var ch in lowWord)
                {
                    if (_vowels.Contains(ch))
                        vowelCounter++;
                }

                if (vowelCounter == word.Length)
                    wordsOfVowelsCounter++;
            }

            return wordsOfVowelsCounter;
        }
    }
}
