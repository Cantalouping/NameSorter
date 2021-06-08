using System;
using System.Collections.Generic;

namespace NameSorter
{
    /// <summary>
    /// Handles execution of the name sorting program.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Executes the name sorting program. Requires one command line argument for the unsorted .txt file.
        /// </summary>
        /// <param name="args">First argument is used to determine the path of the unsorted .txt file. Other arguments ignored.</param>
        static void Main(string[] args)
        {
            // Checks that a file path for a txt file of names has been supplied.
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter the file path for the text file of names to be sorted.");
                return;
            }

            ISourceReader input = new FileReader(args[0]);
            ISourceWriter output = new FileWriter("sorted-names-list.txt");
            ISortComparerHandler handler = new SortComparerHandler(args[1]);
            Sorter sorter = new Sorter(input, output, handler.GetComparer());

            string sortedFile = sorter.Sort();
            Console.Write(sortedFile);
        }
    }
}
