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
        public enum Mode { OriginToAnswer, AnswerToOrigin }
        private Mode SelectedMode { get; set; }

        private List<Word> WordList { get; set; }
        private List<int> WordIndexHistory { get; set; }

        private int currentIndex;
        private Random random;
        #endregion

        #region Constructor(s)
        public RandomWord(List<Word> wordList, Mode mode)
        {
            InitializeComponent();

            Debug.Assert(wordList != null);
            this.WordList = wordList;
            this.SelectedMode = mode;
            random = new Random(DateTime.Now.Millisecond);
            WordIndexHistory = new List<int>();
            currentIndex = -1;

            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            buttonNext_Click(buttonNext, new EventArgs());
            timer.Stop();
        }

        private void clearResult()
        {
            tbAnswer.Clear();
            labelResult.Text = string.Empty;
        }
        #endregion

        #region Methods
        private string getCurrentOrigin()
        {
            var currentWord = WordList[WordIndexHistory[currentIndex]];
            return (this.SelectedMode == RandomWord.Mode.OriginToAnswer ? currentWord.Origin : currentWord.Answer);
        }

        private string getCurrentAnswer()
        {
            var currentWord = WordList[WordIndexHistory[currentIndex]];
            return (this.SelectedMode == RandomWord.Mode.OriginToAnswer ? currentWord.Answer : currentWord.Origin);
        }

        private void showWordAtIndex(int wordIndex)
        {
            clearResult();
            var word = WordList[WordIndexHistory[wordIndex]];
            lblOrigin.Text = getCurrentOrigin();
            tbAnswer.Focus();
        }

        private void showRandomWord()
        {
            clearResult();
            int randomId = random.Next(WordList.Count);
            var word = WordList[randomId];
            WordIndexHistory.Add(randomId);
            currentIndex = WordIndexHistory.Count - 1;
            lblOrigin.Text = getCurrentOrigin();
            tbAnswer.Focus();
        }

        private bool evaluateAnswer(string answer)
        {
            return getCurrentAnswer().Trim().ToUpper().Equals(answer.Trim().ToUpper());
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
                Word word = WordList[WordIndexHistory[currentIndex]];
                (sender as Label).Text = getCurrentAnswer();
            }
        }

        private void lblAnswer_MouseLeave(object sender, EventArgs e)
        {
            lblAnswer.Text = "(Answer)";
        }

        private void buttonCopy1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lblOrigin.Text);
        }
        
        private void buttonCopy2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lblAnswer.Text);
        }

        private void buttonCopy2_MouseMove(object sender, MouseEventArgs e)
        {
            lblAnswer_MouseMove(lblAnswer, e);
        }

        private void buttonCopy2_MouseLeave(object sender, EventArgs e)
        {
            lblAnswer_MouseLeave(lblAnswer, e);
        }

        private void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bool success = evaluateAnswer(tbAnswer.Text);
                labelResult.Text = (success ? "Right!" : "Wrong");
                labelResult.ForeColor = (success ? Color.Green : Color.Red);

                if (success)
                {
                    timer.Start();
                }
                else
                {
                    tbAnswer.Focus();
                }
            }
        }
        #endregion
    }
}
