using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    interface ISortComparerHandler
    {
        IComparer<Person> SetComparer(string choice);
        IComparer<Person> DefaultComparer();
    }
}
