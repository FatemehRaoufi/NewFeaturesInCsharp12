namespace NewFeaturesInCsharp12
{
    /// <summary>
    /// Primary constructors:
    /// 
    /// The first highlight is the ability to use primary constructors which allows adding parameters to the class declaration 
    ///and using them in the class body
    /// Now, any class or struct can have primary constructors. 
    /// The limitation on record types for primary constructors has been removed. 
    /// The scope of the primary constructor parameters extends to the class as a whole. 
    /// All expressly defined constructors must use this() syntax to invoke the primary constructor to guarantee that all primary constructor parameters are unquestionably assigned. 
    /// A class's primary constructor prevents the compiler from declaring an implicit constructor without parameters. 
    /// The implicit parameterless constructor sets the principal constructor parameters and all other fields to the 0-bit pattern in a struct.
    ///
    /// Only in record types, either record class or record struct kinds, does the compiler produce public properties for primary constructor parameters. 
    /// Non-record classes and structs may not always desire this behavior for primary constructor parameters.
    /* 
    This feature was previously only available for record type in C# 9 as part of the positional syntax for records. 
    With primary constructors, developers now can use the parameters to initialize properties or to include them in the code of methods and property accessors.    
     */



    /// </summary>
    internal class PrimaryConstructors
    {
        /// <summary>
        /// Non-record classes and structs' primary constructors

        /// Using aliases for any type Using default lambda expression parameters classes and structs, you can declare a primary constructor starting with C# 12. 
        /// You put any parameters after the type name in brackets:
        /// <summary>
        public PrimaryConstructors()
        {

        }
        public class NamedItem(string name)
        {
            public string Name => name;
        }
        // name isn't captured in Widget.
        // width, height, and depth are captured as private fields
        public class Widget(string name, int width, int height, int depth) : NamedItem(name)
        {
            public Widget() : this("N/A", 1, 1, 1) { } // unnamed unit cube

            public int WidthInCM => width;
            public int HeightInCM => height;
            public int DepthInCM => depth;

            public int Volume => width * height * depth;
        }
        //--------------------
        public class Student(int id, string name, IEnumerable<decimal> grades)
        {
            public Student(int id, string name) : this(id, name, Enumerable.Empty<decimal>()) { }
            public int Id => id;
            public string Name { get; set; } = name.Trim();
            public decimal GPA => grades.Any() ? grades.Average() : 4.0m;
        }
    }
}

//https://learn.microsoft.com/en-in/dotnet/csharp/whats-new/csharp-12#primary-constructors
//https://www.infoq.com/news/2023/04/csharp-12-preview/