using System.Collections.Generic;

namespace VowelsWordCounter.Interfaces
{
    public interface IWordsProcessor
    {
        int GetVowelsCount(List<string> words);
    }
}
