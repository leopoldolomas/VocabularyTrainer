using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianVocabularyHelper
{
    public partial class RandomWord : Form
    {
        #region Vars/Properties
        public List<Word> WordList { get; set; }
        private Word CurrentWord { get; set; }
        private Random random;
        #endregion

        #region Constructor(s)
        public RandomWord()
        {
            InitializeComponent();

            random = new Random(DateTime.Now.Second);
        }
        #endregion

        #region Methods
        private void showRandomWord()
        {
            CurrentWord = WordList[random.Next(WordList.Count)];
            lblRussian.Text = CurrentWord.Russian;
        }
        #endregion

        #region Events
        private void RandomWord_Shown(object sender, EventArgs e)
        {
            showRandomWord();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            showRandomWord();
        }

        private void lblAnswer_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Label).Text = CurrentWord.English;
        }

        private void lblAnswer_MouseLeave(object sender, EventArgs e)
        {
            lblAnswer.Text = "(Answer)";
        }
        #endregion
    }
}
