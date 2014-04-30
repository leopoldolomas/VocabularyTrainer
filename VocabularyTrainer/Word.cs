using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVocabularyHelper
{
    public class Word
    {
        public string Russian { get; set; }
        public string English { get; set; }

        public Word()
        {
            this.Russian = "";
            this.English = "";
        }

        public Word(string russian, string english)
        {
            this.Russian = russian;
            this.English = english;
        }

        public override bool Equals(object obj)
        {
            Word other = obj as Word;
            return this.Russian.Equals(other.Russian) &&
                this.English.Equals(other.English);
        }
    }
}
