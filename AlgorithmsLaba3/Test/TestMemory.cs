using AlgorithmsLaba3.Service;
using System.Management;

namespace AlgorithmsLaba3.Test
{
    internal class TestMemory : IBaseTest<long>
    {
        public static long LastResult = 0;
        public long Run(ITest testTime)
        {
            long[] srTime = new long[5];
            for (int i = 0; i < srTime.Length; i++)
            {
                var startMemory = GC.GetTotalMemory(false) / 1024;
                testTime.Test();
                var endMemory = GC.GetTotalMemory(false) / 1024;
                var result = endMemory - startMemory;
                if (result < 0)
                {
                    result = LastResult;
                }
                else
                {
                    LastResult = result;
                }
                srTime[i] = result;
            }
            return AnamylCorrection(srTime);
        }
        private long AnamylCorrection(long[] time)
        {
            Array.Sort(time);
            return time[2];
        }
    }
}
