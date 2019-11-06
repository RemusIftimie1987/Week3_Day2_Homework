using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab_IComparable
{
    interface ICompareByLength : IComparable
    {
        void CompareByLength(string firstString, string secondString);
    }
}
