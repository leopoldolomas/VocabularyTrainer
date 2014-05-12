using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVocabularyHelper
{
    public class Word
    {
        public string Origin { get; set; }
        public string Answer { get; set; }

        public Word()
        {
            this.Origin = "";
            this.Answer = "";
        }

        public Word(string origin, string answer)
        {
            this.Origin = origin;
            this.Answer = answer;
        }

        public override bool Equals(object obj)
        {
            Word other = obj as Word;
            return this.Origin.Equals(other.Origin) &&
                this.Answer.Equals(other.Answer);
        }
    }
}
