using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorter
{
    class FileWriter : ISourceWriter
    {
        private readonly string path;

        public FileWriter(string path)
        {
            this.path = Path.Combine(Directory.GetCurrentDirectory(), path);
        }

        public string SaveNames(List<Person> persons)
        {
            string namesText = BuildNamesText(persons);

            using (var sw = new StreamWriter(path))
            {
                sw.Write(namesText);
            }

            return namesText;
        }

        private string BuildNamesText(List<Person> persons)
        {
            var names = persons.Select(person => $"{person.GivenNames} {person.LastName}");
            var sb = new StringBuilder();

            foreach (string name in names)
            {
                sb.AppendLine(name);
            }

            return sb.ToString();
        }
    }
}
