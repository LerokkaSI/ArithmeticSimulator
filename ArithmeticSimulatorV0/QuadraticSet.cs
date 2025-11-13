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
    public partial class QuadraticSet : UserControl
    {
        public QuadraticSet()
        {
            InitializeComponent();
        }

        private void QuadraticSet_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            List<ProblemBasic> randomList = new List<ProblemBasic>();
            for (int i = 0; i < trackBarCount.Value; i++)
            {
                randomList.Add(RandomProblem());
            }

            var mainForm = (Form1)this.Parent;
            mainForm.ShowPage(new ProblemPage(randomList));
        }

        private void trackBarCount_Scroll(object sender, EventArgs e)
        {
            labelCount.Text = String.Format("Количество примеров: {0}", trackBarCount.Value);
        }



        private ProblemBasic RandomProblem(int rounding = 0)
        {
            var problem = RandomVars.RandomQuadratic();
            var infoCulture = CultureInfo.InvariantCulture;
            string result = $"{Math.Min(problem.x1, problem.x2)} {Math.Max(problem.x1, problem.x2)}";
            string textProblem = $"{problem.a.ToString(infoCulture)}x² ";
            
            if (problem.b < 0) textProblem += "- ";
            else textProblem += "+ ";
            textProblem += $"{Math.Abs(problem.b).ToString(infoCulture)}x ";

            if (problem.c < 0) textProblem += "- ";
            else textProblem += "+ ";
            textProblem += $"{Math.Abs(problem.c).ToString(infoCulture)} = 0";

            return new ProblemBasic(textProblem, result, ProblemBasic.Quadratic);
        }
    }
}
