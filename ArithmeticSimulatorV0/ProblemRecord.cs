using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticSimulatorV0
{
    public class ProblemRecord
    {
        //Fhanks to Deepseek, потом необходимо доработать и переработать функции записи*
        //09:40... А ещё отчёт писать (TT-TT))

        public DateTime CreatedAt { get; set; }
        public List<ProblemToJSON> Problems { get; set; }

        // Ленивые вычисления
        private int? _totalProblems;
        private int? _correctAnswers;
        private Dictionary<string, int> _problemsByType;
        private Dictionary<string, int> _correctByType;

        public int TotalProblems => _totalProblems ??= Problems.Count;
        public int CorrectAnswers => _correctAnswers ??= Problems.Count(p => p.isCorrectCount);
        public double Accuracy => TotalProblems > 0 ? (double)CorrectAnswers / TotalProblems * 100 : 0;

        public Dictionary<string, int> ProblemsByType =>
        _problemsByType ??= Problems.GroupBy(p => p.TypeProblem)
            .ToDictionary(g => g.Key, g => g.Count());

        public Dictionary<string, int> CorrectByType =>
            _correctByType ??= Problems.GroupBy(p => p.TypeProblem)
                .ToDictionary(g => g.Key, g => g.Count(p => p.isCorrectCount));

        // Метод для сброса кеша при изменении данных
        public void InvalidateCache()
        {
            _totalProblems = null;
            _correctAnswers = null;
            _problemsByType = null;
            _correctByType = null;
        }

        public ProblemRecord(List<ProblemToJSON> problems)
        {
            CreatedAt = DateTime.Now;
            Problems = problems;
        }
    }
}
