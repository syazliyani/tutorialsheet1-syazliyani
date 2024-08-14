// using System;

// namespace PrintComments
// {
//     class Tutorial1
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Welcome to c# programming");
//             //Comments
//             //This is a single line comment
//             /*Comments*/
//             Console.WriteLine("Hello Comments!");

//         }
//     }
// }

// using System;

// namespace IntegerTypes
// {
//     class Tutorial2
//     {
//         static void Main(string[] args)
//         {
//             // int: Commonly used integer type
//             int book = 25;
//             Console.WriteLine("Book: " + book);

//             // long: Used for larger numbers
//             long population = 1912131;
//             Console.WriteLine("Population: " + population);

//             // short: Used for smaller numbers
//             short year = 2024;
//             Console.WriteLine("Year: " + year);

//             // byte: Used for very small numbers or binary data
//             byte age = 12;
//             Console.WriteLine("Age: " + age);

//             float piFloat = 3.14f;
//             Console.WriteLine("Pifloat: " + piFloat);

//             double piDouble = 3.14159265359;    
//             Console.WriteLine("PiDouble: " + piDouble);

//             char grade = 'A';
//             Console.WriteLine("Grade: " + grade);

//             bool isStudent = true;
//             Console.WriteLine("Is Student: " + isStudent);
//         }
//     }
// }

// using System;

// namespace TypeConversion
// {
//     class Tutorial3
//     {
//         static void Main(string[] args)
//         {
//             // Implicit conversion from int to double
//             // int num = 123;
//             // double doubleNum = num;
//             // Console.WriteLine("Implicit Conversion from int to double: " + doubleNum);

//             // Explicit conversion from double to int
//             double pi = 3.1415;
//             int intPi = (int)pi; // Cast double to int
//             Console.WriteLine("Explicit Conversion from double to int: " + intPi);
//             double doubleNum = intPi;
//             Console.WriteLine("Explicit Conversion from int to double: " + doubleNum);

//         }
//     }
// }