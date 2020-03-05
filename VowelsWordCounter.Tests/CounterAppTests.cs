using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using VowelsWordCounter.Interfaces;
using Xunit;

namespace VowelsWordCounter.Tests
{
    public class CounterAppTests
    {
        [Fact]
        public async Task Count()
        {
            var fileProcessor = new Mock<IFileProcessor>();
            var wordProcessor = new Mock<IWordsProcessor>();

            var path = "Files\\sample.txt";
            var words = new List<string> { "aaa", "AAA", "xxx", "XXX", "aax", "o", "z" };
            var expCount = 3;

            fileProcessor.Setup(fp => fp.ReadWords(path))
                .ReturnsAsync(words);
            wordProcessor.Setup(wp => wp.GetVowelsCount(words))
                .Returns(expCount);

            var app = new CounterApp(fileProcessor.Object, wordProcessor.Object);
            var count = await app.Count(path);

            Assert.Equal(expCount, count);
        }
    }
}
