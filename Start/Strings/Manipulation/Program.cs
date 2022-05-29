﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string 
// System.Console.WriteLine($"{str1.Length}");

// TODO: Access individual characters
// System.Console.WriteLine($"{str1[14]}");

// TODO: Iterate over a string like any other sequence of values
// foreach(char ch in str1)
// {
//     System.Console.Write(ch);
//     if(ch == 'b')
//     {
//         System.Console.WriteLine();
//         break;
//     }
// }




// TODO: String Concatenation         
string outstr;
// outstr = String.Concat(str1,str2);
// System.Console.WriteLine($"{outstr}");


// TODO: Joining strings together with Join
// outstr = String.Join('.',strs);
// System.Console.WriteLine($"{outstr}");

// TODO: String Comparison

// Equals just returns a regular Boolean
// bool isEqual = str2.Equals(str3);
// Console.WriteLine($"{isEqual}");

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
System.Console.WriteLine(String.Compare(str2,"This is a string"));

// TODO: Replacing content
outstr = str1.Replace("fox","man");
System.Console.WriteLine(outstr);
