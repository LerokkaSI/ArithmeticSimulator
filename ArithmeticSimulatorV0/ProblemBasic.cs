using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticSimulatorV0
{
    public class ProblemBasic
    {

        public static string MultiDividion = "MultiDividion";
        public static string Quadratic = "Quadratic";
        public static string SumDifference = "SumDifference";
        public string ProblemText { get; set; }
        public string Answer { get; set; }
        public string UserAnswer { get; set; }
        public string TypeProblem { get; set; }
        public ProblemBasic(string problemText, string answer, string typeAnswer)
        { 
            ProblemText = problemText;
            Answer = answer;
            TypeProblem = typeAnswer;
            UserAnswer = "";
        }
    }
}
