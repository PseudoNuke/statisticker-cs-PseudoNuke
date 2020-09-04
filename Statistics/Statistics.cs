using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public double average;
        public double max;
        public double min;
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats obj = new Stats();
            if (numbers.Count == 0) {
                obj.max = double.NaN;
                obj.min = double.NaN;
                obj.average = double.NaN;
                return obj;
            }
            List<double> validNumbers = this.GetValidList(numbers);
            obj.max = validNumbers.Max();
            obj.min = validNumbers.Min();
            obj.average = validNumbers.Average();
            return obj;
        }
        public List<double> GetValidList(List<double> numbers)
        {
            List<double> validNumbers = new List<double>();
            for (int i = 0; i < numbers.Count; i++) {
                if (!double.IsNaN(numbers[i])) {
                    validNumbers.Add(numbers[i]);
                }
            }
            return validNumbers;
        }
    }
}
