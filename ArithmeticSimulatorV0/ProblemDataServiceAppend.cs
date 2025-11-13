using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArithmeticSimulatorV0
{
    public class ProblemDataServiceAppend
    {
        private readonly string _filePath;

        public ProblemDataServiceAppend(string filePath = "problems_data.json")
        {
            _filePath = filePath;
        }

        public void AppendProblems(List<ProblemToJSON> problems)
        {
            var record = new ProblemRecord(problems);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonLine = JsonSerializer.Serialize(record, options);

            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine(jsonLine);
            }
        }

        public List<ProblemRecord> LoadAllRecords()
        {
            if (!File.Exists(_filePath))
                return new List<ProblemRecord>();

            var records = new List<ProblemRecord>();

            foreach (string line in File.ReadLines(_filePath))
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    try
                    {
                        var record = JsonSerializer.Deserialize<ProblemRecord>(line);
                        if (record != null)
                            records.Add(record);
                    }
                    catch (JsonException)
                    {
                        // Пропускаем некорректные строки
                        continue;
                    }
                }
            }

            return records;
        }
    }
}
