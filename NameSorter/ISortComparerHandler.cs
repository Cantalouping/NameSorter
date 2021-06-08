using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public interface ISortComparerHandler
    {
        IComparer<Person> GetComparer();
    }
}
