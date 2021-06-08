using System;
using System.Collections.Generic;

namespace NameSorter
{
    public interface ISourceWriter
    {
        string SaveNames(List<Person> names);
    }
}
