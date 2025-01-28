using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Core.Contracts
{
    internal interface ISorting
    {
        public int[] Sorting(List<int> numbers);
    }
}
