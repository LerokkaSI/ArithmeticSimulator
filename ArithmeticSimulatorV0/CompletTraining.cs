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
    public partial class CompletTraining : UserControl
    {
        private readonly string _filePath;
        private List<ProblemBasic> _problemList;

        public CompletTraining(List<ProblemBasic> problemList)
        {
            _problemList = problemList;
            InitializeComponent();
        }
        private void CompletTraining_Load(object sender, EventArgs e)
        {
            //_problemList[_indexNumber].UserAnswer == _problemList[_indexNumber].Answer
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            var mainForm = (Form1)this.Parent;
            mainForm.ShowPage(new ProblemPage(_problemList, true));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            List<ProblemToJSON> problems = new List<ProblemToJSON>();
            foreach (var problem in _problemList)
            {
                problems.Add(new ProblemToJSON(problem));
            }

            var dataService = new ProblemDataServiceAppend();
            dataService.AppendProblems(problems);

            var mainForm = (Form1)this.Parent;
            mainForm.ShowPage(new MainMenu());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //_problemList[_indexNumber].UserAnswer == _problemList[_indexNumber].Answer
            double X = 0;
            double O = 0;
            for (int i = 0; i < _problemList.Count; i++)
            {
                if (_problemList[i].UserAnswer == _problemList[i].Answer)
                    O++;
                else
                    X++;
            }
            labelProcentValue.Text = Math.Pow(O / (double)_problemList.Count * 100, 2).ToString();
        }
    }
}
