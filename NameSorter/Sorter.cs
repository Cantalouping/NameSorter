using System;
using System.Collections.Generic;

namespace NameSorter
{
    /// <summary>
    /// Used for sorting the names in an unsorted list of names and outputting a sorted list.
    /// </summary>
    public class Sorter
    {
        private readonly ISourceReader input;
        private readonly ISourceWriter output;
        private readonly IComparer<Person> comparer;
        private List<Person> names;
        public Sorter(ISourceReader input, ISourceWriter output, IComparer<Person> comparer)
        {
            this.input = input;
            this.output = output;
            this.comparer = comparer;
        }

        public string Sort()
        {
            GetNamesFromSource();
            SortNames();
            return SaveNamesToSource();
        }

        private void GetNamesFromSource()
        {
            names = input.GetNames();
        }

        private void SortNames()
        {
            names.Sort(comparer);
        }

        private string SaveNamesToSource()
        {
            return output.SaveNames(names);
        }
    }
}
