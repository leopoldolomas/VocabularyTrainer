using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Word> wordList;
        private Config appConfig;
        private string configFilename;
        private Word unmodifiedWord;
        #endregion

        #region Constructor(s)
        public Main()
        {
            InitializeComponent();

            wordList = new List<Word>();
            configFilename = "config.xml";
        }
        #endregion

        #region Methods
        private void clearFields()
        {
            tbEnglish.Text = tbRussian.Text = string.Empty;
        }

        private void loadWordList()
        {
            if(!File.Exists(appConfig.DBFilePath))
            {
                return;
            }

            wordList = null;
            DeserializeObject(ref wordList, appConfig.DBFilePath);

            dgv.DataSource = null;
            dgv.DataSource = wordList;
        }

        private void saveWordList()
        {
            SerializeObject(wordList, appConfig.DBFilePath);
        }

        private void saveConfig()
        {
            SerializeObject(appConfig, configFilename);
        }

        private void loadConfig()
        {
            if (!File.Exists(configFilename))
            {
                appConfig = new Config();
                appConfig.DBFilePath = "words.xml";
                saveConfig();
            }
            DeserializeObject(ref appConfig, configFilename);
            this.TopMost = appConfig.TopMost;
            alwaysOnTopToolStripMenuItem.Checked = this.TopMost;
        }

        private void showRandomWord(RandomWord.Mode mode)
        {
            var randomWordForm = new RandomWord(wordList, mode);
            this.Visible = false;
            randomWordForm.ShowDialog();
            this.Visible = true;
        }
        #endregion

        #region Events
        private void Main_Shown(object sender, EventArgs e)
        {
            loadConfig();
            loadWordList();

            if (dgv.RowCount > 0)
            {
                dgv.AutoResizeColumn(0);
            }
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

        private void tsmiRussianToEnglish_Click(object sender, EventArgs e)
        {
            showRandomWord(RandomWord.Mode.OriginToAnswer);
        }

        private void tsmiEnglishToRussian_Click(object sender, EventArgs e)
        {
            showRandomWord(RandomWord.Mode.AnswerToOrigin);
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            menuItem.Checked = !menuItem.Checked;
            this.TopMost = menuItem.Checked;
            appConfig.TopMost = this.TopMost;
            saveConfig();
        }

        private void tsmiSaveDBAs_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "XML Files | *.xml";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                appConfig.DBFilePath = sfd.FileName;
                saveConfig();
                saveWordList();
            }
        }

        private void tsmiOpenDB_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "XML Files | *.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                appConfig.DBFilePath = ofd.FileName;
                saveConfig();
                loadWordList();
            }
        }

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            unmodifiedWord = new Word(dgv.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                      dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var rows = dgv.Rows[e.RowIndex];
            var cell1 = rows.Cells[0].Value;
            var cell2 = rows.Cells[1].Value;

            if (cell1 != null &&
                cell2 != null &&
                !String.IsNullOrEmpty(cell1.ToString().Trim()) &&
                !String.IsNullOrEmpty(cell2.ToString().Trim()))
            {
                rows.Cells[0].Value = cell1.ToString().Trim();
                rows.Cells[1].Value = cell2.ToString().Trim();
                saveWordList();
            }
            else 
            {
                var word = wordList[e.RowIndex];
                word.Answer = unmodifiedWord.Answer;
                word.Origin = unmodifiedWord.Origin;
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Serialization
        private void SerializeObject<T>(T obj, string xmlFilePath)
        {
            Debug.Assert(obj != null);
            Debug.Assert(!string.IsNullOrEmpty(xmlFilePath));

            if(File.Exists(xmlFilePath))
            {
                File.Delete(xmlFilePath);
            }

            var serializer = new XmlSerializer(typeof(T));
            var stream = File.OpenWrite(xmlFilePath);
            serializer.Serialize(stream, obj);
            stream.Close();
        }

        private void DeserializeObject<T>(ref T obj, string xmlFilePath)
        {
            Debug.Assert(!string.IsNullOrEmpty(xmlFilePath));

            var serializer = new XmlSerializer(typeof(T));
            var stream = new StreamReader(xmlFilePath);
            obj = (T)serializer.Deserialize(stream);
            stream.Close();
        }
        #endregion
    }
}
