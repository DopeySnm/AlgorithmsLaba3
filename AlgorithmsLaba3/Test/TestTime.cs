using AlgorithmsLaba3.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Test
{
    internal class TestTime : IBaseTest<double>
    {
        public double Run(ITest testTime)
        {
            double[] srTime = new double[5];
            for (int j = 0; j < 5; j++)
            {
                Stopwatch time = new Stopwatch();
                time.Start();
                testTime.Test();
                time.Stop();
                Math.Round(srTime[j] = time.Elapsed.TotalMilliseconds);
            }
            return AnamylCorrection(srTime);
        }
        private double AnamylCorrection(double[] time)
        {
            Array.Sort(time);
            return time[2];
        }
    }
}
