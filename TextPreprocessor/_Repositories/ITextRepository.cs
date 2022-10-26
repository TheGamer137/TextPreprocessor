using System.Collections.Generic;
using TextPreprocessor.Models;

namespace TextPreprocessor._Repositories
{
    public interface ITextRepository
    {
        void CreateDatabase();
        bool CheckIfDatabaseExists();
        bool CheckEncoding(string filename);
        void AddWordsToDictionary(Text text);
        void DeleteAllWords();
        IEnumerable<Text> GetAllWords();
        IEnumerable<Text> GetWordByValue(string value);
    }
}