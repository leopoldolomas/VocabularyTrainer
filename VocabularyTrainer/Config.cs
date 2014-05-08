using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVocabularyHelper
{
    public class Config
    {
        public string DBFilePath { get; set; }

        public Config()
        {
            this.DBFilePath = string.Empty;
        }
    }
}
