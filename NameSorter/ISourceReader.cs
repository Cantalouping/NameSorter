using System;
using System.Collections.Generic;

namespace NameSorter
{
    public interface ISourceReader
    {
        List<Person> GetNames();
    }
}
