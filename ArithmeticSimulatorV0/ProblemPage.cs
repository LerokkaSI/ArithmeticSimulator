using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticSimulatorV0
{
    public partial class ProblemPage : UserControl
    {
        private List<ProblemBasic> _problemList;
        private int _indexNumber = 0;
        private bool _complet;

        public ProblemPage(List<ProblemBasic> problemList, bool complet = false)
        {
            _problemList = problemList;
            _complet = complet;
            InitializeComponent();
        }
        private void ProblemPage_Load(object sender, EventArgs e)
        {
            ChangeItem();
            textBox1.Focus();
            if (_complet)
            {
                textBox1.Enabled = false;
                textBox1.Text = _problemList[_indexNumber].UserAnswer;

                buttonFinish.Enabled = true;
            }
            else
            {
                buttonFinish.Enabled = false;
            }
        }
        private void TextBoxColor()
        {
            if (_complet)
            {
                if (_problemList[_indexNumber].UserAnswer == _problemList[_indexNumber].Answer)
                {
                    textBox1.BackColor = Color.LightGreen;
                    textBox1.ForeColor = Color.Black;
                }
                else
                {
                    textBox1.BackColor = Color.Coral;
                    textBox1.ForeColor = Color.White;
                }
            }
        }
        private void ChangeLabelNumber()
        {
            labelNumber.Text = $"{_indexNumber + 1} / {_problemList.Count}";
        }
        private void ChangeLabelProblem()
        {
            labelProblem.Text = _problemList[_indexNumber].ProblemText;
        }
        private void ChangeRightAnswer()
        {
            if (_complet) labelRightAnswer.Text = _problemList[_indexNumber].Answer;
        }
        private void ChangeDefoltText()
        {
            if (_problemList[_indexNumber].TypeProblem == ProblemBasic.Quadratic)
            {
                labelDefoltText.Text = "Введите значения корней уравнения, через пробел, начиная с наименьшего корня";
            } 
            else
            {
                labelDefoltText.Text = "Введите, чему равно (?): ";
            }
        }
        private void InsertUserAnswer()
        {
            textBox1.Text = _problemList[_indexNumber].UserAnswer;
        }
        private void ChangeItem()
        {
            ChangeLabelProblem();
            ChangeLabelNumber();
            InsertUserAnswer();
            ChangeRightAnswer();
            TextBoxColor();
            ChangeDefoltText();
        }
        private void SaveAnswerAndClear()
        {
            _problemList[_indexNumber].UserAnswer = textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            ////
        }

        private void labelProblem_Click(object sender, EventArgs e)
        {
            ///
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SaveAnswerAndClear();
            if (_indexNumber <= 0) _indexNumber = 0;
            else _indexNumber--;
            ChangeItem();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            SaveAnswerAndClear();
            if (_indexNumber < _problemList.Count - 1) _indexNumber++;
            if (_indexNumber == _problemList.Count - 1)
            {
                buttonFinish.Enabled = true;
            }
            ChangeItem();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Некая символьная вставка
            if (e.KeyChar == (char)22) e.Handled = true;

            var textBox = (TextBox)sender;
            string text = textBox.Text;
            int cursorPos = textBox.SelectionStart;


            if (e.KeyChar == '-')
            {
                if (cursorPos == 0) return;
                if (cursorPos > 0 && (text[cursorPos - 1] == ','))
                {
                    e.Handled = true;

                    textBox.Text = text.Insert(cursorPos, " -");
                    textBox.SelectionStart = cursorPos + 2;
                    return;
                }
                else if (text[cursorPos - 1] == ' ') return;
            }

            //Ввод точки
            if (e.KeyChar == '.')
            {
                // Проверяем, нет ли уже точки в текущем числе
                string currentNumber = GetCurrentNumber(text, cursorPos);
                if (!currentNumber.Contains('.'))
                {
                    if (!(cursorPos == 0) && (
                        //
                        (text[cursorPos - 1] != ' ' && text[cursorPos - 1] != '-')))
                        return;
                    else
                    {
                        e.Handled = true;
                        textBox.Text = text.Insert(cursorPos, "0.");
                        textBox.SelectionStart = cursorPos + 2;
                        return;
                    }
                }
            }



            //Особенности ввода для квадратных уравнений
            if (_problemList[_indexNumber].TypeProblem == ProblemBasic.Quadratic)
            {
                ////Ввод запятой
                //if (e.KeyChar == ',' && !text.Contains(',') && cursorPos > 0)
                //{
                //    if (text.Contains(' ') && text[cursorPos] == ' ')
                //    {
                //        return;
                //    }
                //}
                //Ввод пробела

                ////Цифра после запятой и нет пробела
                //if (char.IsDigit(e.KeyChar) && cursorPos > 0 && text[cursorPos - 1] == ',')
                //{
                //    e.Handled = true;

                //    textBox.Text = text.Insert(cursorPos, " " + e.KeyChar);
                //    textBox.SelectionStart = cursorPos + 2;
                //    return;
                //}

                if (e.KeyChar == ' ' && (!text.Contains(' ')) && cursorPos > 0
                    && (text[cursorPos - 1] != '.'))
                {
                    return;
                }

                if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            }
            else //Особенности ввода для не квадратных уравнений
            {
                ///   
            }

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.V) ||
                (e.Shift && e.KeyCode == Keys.Insert))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyData == Keys.Enter)
            {
                buttonNext_Click(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ///
        }

        private string GetCurrentNumber(string text, int cursorPos)
        {
            int start = cursorPos;
            int end = cursorPos;

            // Идем влево пока символы подходят для числа
            while (start > 0 && "0123456789.-".Contains(text[start - 1]))
                start--;

            // Идем вправо пока символы подходят для числа
            while (end < text.Length && "0123456789.-".Contains(text[end]))
                end++;

            return text.Substring(start, end - start);

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            SaveAnswerAndClear();
            var mainForm = (Form1)this.Parent;
            mainForm.ShowPage(new CompletTraining(_problemList));
        }
    }
}
