using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorter
{
    class FileReader : ISourceReader
    {
        private readonly string path;

        public FileReader(string path)
        {
            this.path = Path.Combine(Directory.GetCurrentDirectory(), path);
        }
        public List<Person> GetNames()
        {
            char delimiter = ' ';
            var persons = new List<Person>();

            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} does not exist.");
                Environment.Exit(0);
            }

            foreach (string line in File.ReadLines(path))
            {
                var separatorIndex = line.LastIndexOf(delimiter);
                var givenNames = line[..separatorIndex].Trim();
                var lastName = line[separatorIndex..].Trim();
                var person = new Person(givenNames, lastName);

                persons.Add(person);
            }

            return persons;
        }
    }
}
