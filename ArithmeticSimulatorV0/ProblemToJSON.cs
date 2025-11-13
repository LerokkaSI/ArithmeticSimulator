using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticSimulatorV0
{
    public class ProblemToJSON : ProblemBasic
    {
        public bool isCorrectCount => Answer == UserAnswer;
        public ProblemToJSON(ProblemBasic basic)
            : base(basic.ProblemText, basic.Answer, basic.TypeProblem)
        {
            UserAnswer = basic.UserAnswer;
        }
    }
}
