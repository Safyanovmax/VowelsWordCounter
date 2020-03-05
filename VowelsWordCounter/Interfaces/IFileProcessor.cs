using System.Collections.Generic;
using System.Threading.Tasks;

namespace VowelsWordCounter.Interfaces
{
    public interface IFileProcessor
    {
        Task<List<string>> ReadWords(string path);

    }
}
