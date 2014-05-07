using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RussianVocabularyHelper
{
    public partial class Main : Form
    {
        #region Vars/Properties
        private List<Word> wordList = new List<Word>();
        private string fileName = "words.xml";
        #endregion

        #region Constructor(s)
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void clearFields()
        {
            tbEnglish.Text = tbRussian.Text = string.Empty;
        }

        private void loadWordList()
        {
            if(!File.Exists(fileName))
            {
                return;
            }

            var serializer = new XmlSerializer(typeof(List<Word>));
            var stream = new StreamReader(fileName);
            wordList = (List<Word>)serializer.Deserialize(stream);
            stream.Close();

            dgv.DataSource = null;
            dgv.DataSource = wordList;
        }

        private void saveWordList()
        {
            var serializer = new XmlSerializer(typeof(List<Word>));
            var stream = File.OpenWrite(fileName);
            serializer.Serialize(stream, wordList);
            stream.Close();
        }
        #endregion

        #region Events
        private void Main_Shown(object sender, EventArgs e)
        {
            loadWordList();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRussian.Text.Trim()) || string.IsNullOrEmpty(tbEnglish.Text.Trim()))
            {
                return;
            }

            var word = new Word(tbRussian.Text.Trim(), tbEnglish.Text.Trim());
            
            if(wordList.Contains(word))
            {
                clearFields();
                return;
            }

            wordList.Add(word);
            dgv.DataSource = null;
            dgv.DataSource = wordList;

            clearFields();
            saveWordList();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var randomWordForm = new RandomWord(wordList);
            this.Visible = false;
            randomWordForm.ShowDialog();
            this.Visible = true;
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            menuItem.Checked = !menuItem.Checked;
            this.TopMost = menuItem.Checked;
        }
        #endregion
    }
}
