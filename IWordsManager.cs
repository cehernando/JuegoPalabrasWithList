using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPalabrasWithList
{
    public interface IWordManager
    {
        void AddWordToAvailable(Word w);
        void ListWords();
        void RemoveWord(int id);
        void EmptyWords();
        void GetRandomWord();
        void SafeToFile();
        void ReadFromFile();
    }
}