using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats obj = new Stats();
            if (numbers.Count > 0) {
                obj.max = numbers.Max();
                obj.min = numbers.Min();
                obj.average = numbers.Average();
            }
            else {
                obj.max = double.NaN;
                obj.min = double.NaN;
                obj.average = double.NaN;
            }
            return obj;
        }
    }
}
