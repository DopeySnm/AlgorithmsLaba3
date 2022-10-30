using AlgorithmsLaba3.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLaba3.Tasks.Task1;

namespace AlgorithmsLaba3.Test
{
    internal class TestMemory : IBaseTest
    {
        public double Run(ITest testTime)
        {
            Process currentProcess = Process.GetCurrentProcess();
            double[] srTime = new double[5];
            for (int j = 0; j < 5; j++)
            {
                long usedMemoryBefore = GC.GetTotalMemory(true);
                testTime.Test();
                long usedMemoryAfter = GC.GetTotalMemory(true);
                srTime[j] = usedMemoryBefore - usedMemoryAfter;
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
