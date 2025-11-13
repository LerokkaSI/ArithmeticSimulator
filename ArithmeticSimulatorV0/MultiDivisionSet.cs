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

namespace ArithmeticSimulatorV0
{
    public partial class MultiDivisionSet : UserControl
    {
        public MultiDivisionSet()
        {
            InitializeComponent();
        }

        private void trackBarMinMax_Scroll(object sender, EventArgs e)
        {
            labelMinMax.Text = String.Format("Диапазон значений: ±{0}", Math.Pow(10, trackBarMinMax.Value));
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
        private void trackBarCount_Scroll(object sender, EventArgs e)
        {
            labelCount.Text = String.Format("Количество примеров: {0}", trackBarCount.Value);
        }



        private static readonly Random _globalRandom = new Random();
        private ProblemBasic RandomProblem(int minMax, int rounding = 0)
        {
            var problem = RandomVars.RandomMulti(-minMax, minMax, 0);
            var infoCulture = CultureInfo.InvariantCulture;
            string result = "";
            string textProblem = "";
            if (_globalRandom.Next(2) == 0)
            {
                textProblem += $"{problem.a.ToString(infoCulture)} * " +
                    $"{problem.b.ToString(infoCulture)} ";
                result = problem.result.ToString(infoCulture);
            }
            else
            {
                textProblem = $"{problem.result.ToString(infoCulture)} / " +
                    $"{problem.b.ToString(infoCulture)} ";
                result = problem.a.ToString(infoCulture);
            }
            textProblem += "= (?)";

            return new ProblemBasic(textProblem, problem.result.ToString(CultureInfo.InvariantCulture), ProblemBasic.SumDifference);
        }

    }
}
