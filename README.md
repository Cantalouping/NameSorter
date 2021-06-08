# NameSorter

Sorts a given text file with a list of names and outputs a list of those names, alphabetically sorted. The sorted list is output to the shell window and creates a file in the working directory called *sorted-names-list.txt* which contains the sorted list of names. Created in C#.

## Getting Started

### Running the program

To run the program, simply navigate to the *NameSorter\bin\Debug\netcoreapp3.1* folder in your desired shell, and run the code below. Note that a path to a valid text file must be supplied. *unsorted-names-list.txt* is not supplied. 

```
NameSorter.exe ./unsorted-names-list.txt
```

The text file should include a list of names, separated by new lines. Each name must have at least one given name and one last name. Names should be separated by spaces.

### Setting up the project locally

This project was created in Visual Studio. Provided that you have a version of Visual Studio installed, simply download the files in this repository and open the *NameSorter.sln* file. This will include the class files used to compile the program, as well as the testing classes.

### Running tests

This project uses the NUnit unit testing framework for its tests. To run the tests in Visual Studio, ensure you have the **NUnit** and **NUnit3TestAdapter** packages installed in Visual Studio. These can be retrieved through the NuGet Package Manager by navigating to *Tools > NuGet Package Manager > Manage NuGet Packages for Solution...* in Visual Studio's dropdown menu and searching for "NUnit".

## Built With

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/) - coded in C#
* [NUnit](https://nunit.org/) - unit testing

## Authors

* **Ameer Sabri**