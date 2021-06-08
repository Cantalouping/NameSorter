# NameSorter

Sorts a given text file with a list of names and outputs a list of those names, alphabetically sorted. The sorted list is output to the shell window and creates a file in the working directory called *sorted-names-list.txt* which contains the sorted list of names. Created in C#.

## Getting Started

### Running the program

To run the program, download the files in the repository and build a solution in Visual Studio. Navigate to the folder where the *NameSorter.exe* was built in your preferred shell and run the command below, with a file path to the text file to be sorted as an argument.  

```
NameSorter ./your-names-file.txt
```

Note that a path to a valid text file must be supplied. The text file should include a list of names, separated by new lines. Each name must have at least one given name and one last name. Names should be separated by spaces.

### Running the program with a defined sort order

If you wish to define the type of sort you wish to use, you can supply the following characters as a second argument after the file path to the text file.

```
a - sorts the text file in ascending alphabetical order.
d - sorts the text file in descending alphabetical order.
```

Example input for sorting a names text file in descending alphabetical order, in your chosen shell:

```
NameSorter ./names-file.txt d
```

If the sort order is omitted, the program will sort the names into ascending alphabetical order by default.


### Setting up the project locally

This project was created in Visual Studio. Provided that you have a version of Visual Studio installed, simply download the files in this repository and open the *NameSorter.sln* file. This will include the class files used to compile the program, as well as the testing classes.

### Running tests

This project uses the NUnit unit testing framework for its tests. To run the tests in Visual Studio, ensure you have the **NUnit** and **NUnit3TestAdapter** packages installed in Visual Studio. These can be retrieved through the NuGet Package Manager by navigating to *Tools > NuGet Package Manager > Manage NuGet Packages for Solution...* in Visual Studio's dropdown menu and searching for "NUnit".

## Built With

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/) - coded in C#
* [NUnit](https://nunit.org/) - unit testing

## Authors

* **Ameer Sabri**