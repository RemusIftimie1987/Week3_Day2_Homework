using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab_IComparable
{
    public interface ICompareByName : IComparable
    {
        int CompareByName(string firstString, string secondString);
    }
}
