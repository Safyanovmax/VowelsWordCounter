using System.Threading.Tasks;
using VowelsWordCounter.Interfaces;

namespace VowelsWordCounter
{
    public class CounterApp
    {
        private readonly IFileProcessor _fileProcessor;
        private readonly IWordsProcessor _wordsProcessor;
        
        public CounterApp(IFileProcessor fileProcessor, IWordsProcessor wordsProcessor)
        {
            _fileProcessor = fileProcessor;
            _wordsProcessor = wordsProcessor;
        }

        public async Task<int> Count(string path)
        {
            var words = await _fileProcessor.ReadWords(path);
            var count = _wordsProcessor.GetVowelsCount(words);

            return count;
        }
    }
}
