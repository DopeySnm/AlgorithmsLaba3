using AlgorithmsLaba3.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Test
{
    internal interface IBaseTest<T>
    {
        public T Run(ITest testTime);
    }
}
