using System;
using System.Collections.Generic;

namespace NameSorter
{
    /// <summary>
    /// Compare class used for the alphabetical sorting of the names for the list.
    /// </summary>
    public class AlphabeticalAscendingComparer : IComparer<Person>
    {
        /// <summary>
        /// Compares the names of two Persons.
        /// Compares by last name first, and then by given names if the last names are the same.
        /// </summary>
        /// <param name="p1">The first Person to be compared.</param>
        /// <param name="p2">The second Person to be compared.</param>
        /// <returns>An integer that indicates the Person's relative position in the sort.</returns>
        public int Compare(Person p1, Person p2)
        {
            var lastNameComparison = string.Compare(p1.LastName, p2.LastName, StringComparison.InvariantCultureIgnoreCase);

            // Checks the given names if the last names are the same
            if (lastNameComparison == 0)
            {
                var givenNamesComparison = string.Compare(p1.GivenNames, p2.GivenNames, StringComparison.InvariantCultureIgnoreCase);
                return givenNamesComparison;
            }

            return lastNameComparison;
        }
    }
}