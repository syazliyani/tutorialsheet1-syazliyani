// using System;

// namespace TutorialSheet1
// {
//     class Question1
//     {
//         static void Main(string[] args)
//         {
//             // Prompt for and read user input
//             Console.WriteLine("Enter your first name: ");
//             string firstName = Console.ReadLine();

//             Console.WriteLine("Enter your last name: ");
//             string lastName = Console.ReadLine();

//             Console.Write("Enter your age: ");
//             int age = int.Parse(Console.ReadLine());

//             // Concatenate first and last name
//             string fullName = $"{firstName} {lastName}";

//             // Calculate years until 100
//             int yearsTo100 = 100 - age;

//             // Display output
//             Console.WriteLine($"Hello, {fullName}. You will turn 100 in {yearsTo100} years.");
//         }
//     }
// }

// using System;

// namespace TutorialSheet1
// {
//     class Question2
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a word:");
//             string word = Console.ReadLine();

//             // Loop through each character in the word
//             for (int i = 0; i < word.Length; i++)
//             {
//                 Console.WriteLine($"Character {i + 1}: {word[i]}");
//             }
//         }
//     }
// }
// using System;

// namespace TutorialSheet1
// {
//     class Question3
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter the first string:");
//             string firstString = Console.ReadLine();

//             Console.WriteLine("Enter the sceond string:");
//             string secondString = Console.ReadLine();

//             if (firstString == secondString)
//             {
//                 Console.WriteLine("The strings are equal.");
//             }
//             else
//             {
//                 Console.WriteLine("The strings are not equal.");
//             }
//         }
//     }
// }

// using System; ////////// cant solve ////////////////////////////

// namespace TutorialSheet1
// {
//     class Question4
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter the radius of the circle:");
//             string radius = Console.ReadLine();

//             // Display Output for the area and circumference
//             Console.WriteLine($"For a circle with radius {radius}, Area: {area} and circumference: {circumference}");
//         }
//     }
// }

// using System;

// namespace TutorialSheet1
// {
//     class Question5
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a sentences:");
//             string sentences = Console.ReadLine();

//             // Extract the first word
//             string firstWord = sentences.Split(' ')[0];

//             // Count vowels in the first word
//             int vowelCount = firstWord.Count(c => "aeiouAEIOU".Contains(c));

//             // Display the result
//             Console.WriteLine($"The first word is '{firstWord}', which contains {vowelCount} vowels.");
//         }
//     }
// }

// using System;

// namespace TutorialSheet1
// {
//     class Question6
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a string:");
//             string astring = Console.ReadLine();
//             char[] charArray = astring.ToCharArray();
//             Array.Reverse(charArray);
//             string reversed = new string(charArray);
//             Console.WriteLine($"Enter a string: {astring}");
//             Console.WriteLine($"Reversed string: {reversed}");

//             // Palindrome check
//             if (astring.Equals(reversed, StringComparison.OrdinalIgnoreCase))
//             {
//                 Console.WriteLine("The string is a palindrome.");
//             }
//             else
//             {
//                 Console.WriteLine("The string is not a palindrome.");
//             }
//         }
//     }
// }

// using System;

// namespace TutorialSheet1
// {
//     class Question7
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a string:");
//             string asstring = Console.ReadLine();

//             // Create a dictionary to store character frequencies
//             Dictionary<char, int> charFrequency = new Dictionary<char, int>();

//             // Count the frequency of each character
//             foreach (char c in asstring)
//             {
//                 if (charFrequency.ContainsKey(c))
//                 {
//                     charFrequency[c]++;
//                 }
//                 else
//                 {
//                     charFrequency[c] = 1;
//                 }
//             }

//             // Display the results
//             Console.WriteLine("Character frequencies:");
//             foreach (var kvp in charFrequency)
//             {
//                 Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//             }
//         }
//     }
// }
// using System;

// namespace TutorialSheet1
// {
//     class Question8
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter your birthday (YYYY/MM/DD):");
//             string birthdate = Console.ReadLine();

//             // convert the birthdate string into a DateTime object
//             if (DateTime.TryParse(birthdate, out DateTime birthdateObj))
//             {
//                 // Calculate lived days
//                 TimeSpan livedDays = DateTime.Today - birthdateObj;

//                 Console.WriteLine($"You have lived for {livedDays.Days} days.");
//             }
//         }
//     }
// }

// using System;

// namespace TutorialSheet1
// {
//     class Question9
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a sentences:");
//             string sentences = Console.ReadLine();
//             string firstUpperCase = char.ToUpper(sentences[0]) + sentences.Substring(1); // takes the first character of the string (lower[0]) and converts it to uppercase using the char.ToUpper() method.
// // lower.Substring(1): This returns a new string that is a substring of lower, starting from index 1 (the second character) to the end of the string.
// // then concatenate these two parts to form the new string with only the first letter capitalized.
//             Console.WriteLine($"Enter a sentences: {sentences}");
//             Console.WriteLine($"Capitalized Sentences: {firstUpperCase}");
//         }
//     }
// }

// using System;

// namespace TutorialSheet1
// {
//     class Question10
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a sentences:");
//             string sentences = Console.ReadLine();

//             // Split the sentence into words
//             string[] words = sentences.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//             // Display the number of words
//             Console.WriteLine($"Number of words: {words.Length}");

//             // Display each word on a new line
//             for (int i = 0; i < words.Length; i++)
//             {
//                 Console.WriteLine($"Word {i + 1}: {words[i]}");
//             }

//         }
//     }
// }

// using System; ////////// cant solve ////////////////////////////

// namespace TutorialSheet1
// {
//     class Question11
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter the first string:");
//             string fstring = Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace TutorialSheet1
// {
//     class Question14
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a sentence: ");
//             string sentence = Console.ReadLine();

//             string[] words = sentence.Split(' ');
//             int maxLength = words.Max(word => word.Length);

//             var longestWords = words.Where(word => word.Length == maxLength);

//             Console.WriteLine("Longest word(s): " + string.Join(", ", longestWords));
//         }
//     }
// }

// using System;
// using System.Text.RegularExpressions;

// namespace TutorialSheet1
// {
//     class Question15
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a password: ");
//             string password = Console.ReadLine();

//             string strength = CheckPasswordStrength(password);
//             Console.WriteLine($"Password Strength: {strength}");
//         }

//         static string CheckPasswordStrength(string password)
//         {
//             int score = 0;

//             if (password.Length >= 8)
//                 score++;
//             if (password.Length >= 12)
//                 score++;
//             if (Regex.IsMatch(password, @"[A-Z]"))
//                 score++;
//             if (Regex.IsMatch(password, @"[a-z]"))
//                 score++;
//             if (Regex.IsMatch(password, @"[0-9]"))
//                 score++;
//             if (Regex.IsMatch(password, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>/?]"))
//                 score++;

//             return score switch
//             {
//                 0 or 1 or 2 => "Weak",
//                 3 or 4 => "Medium",
//                 5 or 6 => "Strong",
//                 _ => "Very Strong"
//             };
//         }
//     }
// }

// using System;
// using System.Text.RegularExpressions;

// namespace TutorialSheet1
// {
//     class Question18
//     {
//         static void Main()
//         {
//             Console.Write("Enter the main string: ");
//             string mainString = Console.ReadLine();

//             Console.Write("Enter the substring to find: ");
//             string findSubstring = Console.ReadLine();

//             Console.Write("Enter the substring to replace it with: ");
//             string replaceSubstring = Console.ReadLine();

//             string resultString = ReplaceSubstring(mainString, findSubstring, replaceSubstring);

//             Console.WriteLine("Resulting String: " + resultString);
//         }

//         static string ReplaceSubstring(string mainString, string findSubstring, string replaceSubstring)
//         {
//             if (string.IsNullOrEmpty(findSubstring))
//                 return mainString;

//             return Regex.Replace(mainString, Regex.Escape(findSubstring), replaceSubstring, RegexOptions.IgnoreCase);
//         }
//     }
// }
// using System;

// namespace TutorialSheet1
// {
//     class Question19
//     {
//         static void Main(strin)
//         {
//             Console.WriteLine("Enter a sentence: ");
//             string sentence = Console.ReadLine();

//             string[] words = sentence.Split(' ');
//             string reversedSentence = string.Join(" ", words.Reverse());

//             Console.WriteLine("Reversed Sentence: " + reversedSentence);
//         }
//     }
// }

// using System;

// namespace TutorialSheet1
// {
//     class Question20
//     {
//         static void Main()
//         {
//             Console.Write("Enter the number: ");
//             string number = Console.ReadLine();

//             Console.Write("Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal): ");
//             int fromBase = int.Parse(Console.ReadLine());

//             Console.Write("Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal): ");
//             int toBase = int.Parse(Console.ReadLine());

//             int decimalValue = Convert.ToInt32(number, fromBase);
//             string convertedNumber = Convert.ToString(decimalValue, toBase);

//             Console.WriteLine("Converted Number: " + convertedNumber.ToUpper());
//         }
//     }
// }