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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mainForm = (Form1)this.Parent;
            mainForm.ShowPage(new QuadraticSet());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mainForm = (Form1)this.Parent;
            mainForm.ShowPage(new MultiDivisionSet());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = (Form1)this.Parent;
            mainForm.ShowPage(new SumDifferenceSet());
        }
    }
}
