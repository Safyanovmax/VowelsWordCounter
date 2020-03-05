using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using VowelsWordCounter.Interfaces;

namespace VowelsWordCounter.Implementations
{
    public class FileProcessor : IFileProcessor
    {
        public async Task<List<string>> ReadWords(string path)
        {
            var words = new List<string>();

            using (var streamReader = new StreamReader(path))
            {
                string line;
                while ((line = await streamReader.ReadLineAsync()) != null)
                {
                    words.AddRange(line
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                }
            }

            return words;
        }
    }
}
