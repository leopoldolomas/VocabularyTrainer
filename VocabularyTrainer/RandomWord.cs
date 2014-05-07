using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Word> WordList { get; set; }
        private List<int> WordIndexHistory { get; set; }

        private int currentIndex;
        private Random random;
        #endregion

        #region Constructor(s)
        public RandomWord(List<Word> wordList)
        {
            InitializeComponent();

            Debug.Assert(wordList != null);
            WordList = wordList;
            random = new Random(DateTime.Now.Second);
            WordIndexHistory = new List<int>();
            currentIndex = -1;
        }
        #endregion

        #region Methods
        private void showWordAtIndex(int wordIndex)
        {
            var word = WordList[WordIndexHistory[wordIndex]];
            lblRussian.Text = word.Russian;
        }

        private void showRandomWord()
        {
            int randomId = random.Next(WordList.Count);
            var word = WordList[randomId];
            WordIndexHistory.Add(randomId);
            currentIndex = WordIndexHistory.Count - 1;
            lblRussian.Text = word.Russian;
        }
        #endregion

        #region Events
        private void RandomWord_Shown(object sender, EventArgs e)
        {
            showRandomWord();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentIndex <= 0)
            {
                return;
            }
            showWordAtIndex(--currentIndex);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (WordList.Count == 0)
            {
                return;
            }

            if (currentIndex < WordIndexHistory.Count - 1)
            {
                showWordAtIndex(++currentIndex);
            }
            else
            {
                showRandomWord();
            }
        }

        private void lblAnswer_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentIndex > -1)
            {
                (sender as Label).Text = WordList[WordIndexHistory[currentIndex]].English;
            }
        }

        private void lblAnswer_MouseLeave(object sender, EventArgs e)
        {
            lblAnswer.Text = "(Answer)";
        }
        #endregion
    }
}
