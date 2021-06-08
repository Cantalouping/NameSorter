using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    class SortComparerHandler : ISortComparerHandler
    {
        private IComparer<Person> comparer;

        public SortComparerHandler(string choice)
        {
            ChooseComparer(choice);
        }
        private void ChooseComparer(string choice)
        {
            switch(choice)
            {
                case "a":
                    comparer = new AlphabeticalAscendingComparer();
                    break;
                case "d":
                    comparer = new AlphabeticalDescendingComparer();
                    break;
                default:
                    comparer = new AlphabeticalAscendingComparer();
                    break;
            }
        }

        public IComparer<Person> GetComparer()
        {
            return comparer;
        }
    }
}
