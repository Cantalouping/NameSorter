using System;

namespace NameSorter
{
    /// <summary>
    /// The Person class.
    /// Used for handling names after they have been read from the text file.
    /// </summary>
    public class Person
    {
        /// <summary>
        ///  Initialises a new instance of the Person class.
        /// </summary>
        /// <param name="givenNames">The given name(s) of the Person to be created.</param>
        /// <param name="lastName">The last name of the Person to be created.</param>
        public Person(string givenNames, string lastName)
        {
            GivenNames = givenNames;
            LastName = lastName;
        }

        public string GivenNames { get; internal set; }
        public string LastName { get; internal set; }

        /// <summary>
        /// Overrides Equals method, used for testing.
        /// </summary>
        /// <param name="obj">Object being compared with the Person.</param>
        /// <returns>True if the other object is a Person with the same last name and given names, False otherwise.</returns>
        public override bool Equals(object obj)
        {
            if(obj.GetType() != GetType())
            {
                return false;
            }

            var person = obj as Person;
            if((LastName == person.LastName) && (GivenNames == person.GivenNames))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overridden as required when overriding the Equals method.
        /// </summary>
        /// <returns>The Person's hash code.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Returns the string representation of a Person.
        /// </summary>
        /// <returns>A string with the given names and last name of the Person.</returns>
        public override string ToString()
        {
            return $"{GivenNames} {LastName}";
        }
    }
}
