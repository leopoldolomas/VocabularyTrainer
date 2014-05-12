using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVocabularyHelper
{
    public class Config
    {
        public bool TopMost { get; set; }
        public string DBFilePath { get; set; }

        public Config()
        {
            this.DBFilePath = string.Empty;
            this.TopMost = true;
        }
    }
}
