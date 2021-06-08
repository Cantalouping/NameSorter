using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorter
{
    /// <summary>
    /// Handles the IO operations and parsing of the name data, both as input as unsorted data and output as sorted data.
    /// </summary>
    public class NamesProcessor
    {
        /// <summary>
        /// Gets the names from the unsorted .txt file and stores the data in a list of Persons.
        /// </summary>
        /// <param name="file">The name/path of the unsorted .txt file.</param>
        /// <returns>The unsorted names as a list of Persons.</returns>
        public List<Person> GetNamesFromFile(string file)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), file);
            var delimiter = ' ';
            var unsortedNames = new List<Person>();

            if(!File.Exists(path))
            {
                Console.WriteLine($"{path} does not exist.");
                Environment.Exit(0);
            }

            foreach(string line in File.ReadLines(path))
            {
                var separatorIndex = line.LastIndexOf(delimiter);
                var givenNames = line[..separatorIndex].Trim();
                var lastName = line[separatorIndex..].Trim();
                var person = new Person(givenNames, lastName);

                unsortedNames.Add(person);
            }

            return unsortedNames;
        }

        /// <summary>
        /// Saves the names from a list of Persons and stores the data in a designated file.
        /// </summary>
        /// <param name="sortedNames">The sorted list of Persons.</param>
        /// <param name="file">The name/path of the desired sorted output file.</param>
        /// <returns>The sorted names in a newline-separated string.</returns>
        public string SaveNamesToFile(List<Person> sortedNames, string file)
        {
            var names = sortedNames.Select(person => $"{person.GivenNames} {person.LastName}");
            var sb = new StringBuilder();

            foreach(string name in names)
            {
                sb.AppendLine(name);
            }

            var sortedNamesText = sb.ToString();
            string path = Path.Combine(Directory.GetCurrentDirectory(), file);
            using (var sw = new StreamWriter(path))
            {
                sw.Write(sortedNamesText);
            } 

            return sortedNamesText.Trim();
        }
    }
}
