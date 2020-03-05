using System.Linq;
using VowelsWordCounter.Implementations;
using Xunit;

namespace VowelsWordCounter.Tests
{
    public class WordsProcessorTests
    {
        [Theory]
        [InlineData(new[] { "aaa", "AAA", "xxx", "XXX", "aax", "o", "z" }, 3)]
        [InlineData(new[] { " " }, 0)]
        public void ProcessWords(string[] words, int exp)
        {
            var wordProcessor = new WordsProcessor();
            var count = wordProcessor.GetVowelsCount(words.ToList());
            Assert.Equal(exp, count);
        }
    }
}
