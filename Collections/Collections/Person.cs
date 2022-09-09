using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Person : IComparable, IEquatable<Person>
    {
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            return Name.CompareTo(((Person)obj).Name);
        }

        public bool Equals([AllowNull] Person other)
        {
            return Name == other.Name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
