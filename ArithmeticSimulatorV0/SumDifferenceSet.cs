using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArithmeticSimulatorV0
{
    public partial class SumDifferenceSet : UserControl
    {
        public SumDifferenceSet()
        {
            InitializeComponent();
        }

        private void trackBarMinMax_Scroll(object sender, EventArgs e)
        {
            labelMinMax.Text = String.Format("Диапазон значений: ±{0}", Math.Pow(10, trackBarMinMax.Value));
        }

        private void trackBarCount_Scroll(object sender, EventArgs e)
        {
            labelCount.Text = String.Format("Количество примеров: {0}", trackBarCount.Value);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int minMax = (int)Math.Pow(10, (double)trackBarMinMax.Value);
            List<ProblemBasic> randomList = new List<ProblemBasic>();
            for (int i = 0; i < trackBarCount.Value; i++)
            {
                randomList.Add(RandomProblem(minMax));
            }

            var mainForm = (Form1)this.Parent;
            mainForm.ShowPage(new ProblemPage(randomList));
        }

        private ProblemBasic RandomProblem(int minMax, int rounding = 0)
        {
            var problem = RandomVars.RandomSumm(-minMax, minMax, 0);
            string textProblem = $"{problem.a.ToString(CultureInfo.InvariantCulture)} ";
            if (problem.b > 0)
            {
                textProblem += $"+ {problem.b.ToString(CultureInfo.InvariantCulture)} ";
            }
            else
            {
                textProblem += $"- {Math.Abs(problem.b).ToString(CultureInfo.InvariantCulture)} ";
            }
            textProblem += "= (?)";

            return new ProblemBasic(textProblem, problem.result.ToString(CultureInfo.InvariantCulture), ProblemBasic.SumDifference);
        }
    }
}
