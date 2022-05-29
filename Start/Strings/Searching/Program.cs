// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
System.Console.WriteLine($"{teststr.Contains("fox")}");

// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
System.Console.WriteLine($"{teststr.StartsWith("The")}");

// TODO: IndexOf, LastIndexOf finds the index of a substring
System.Console.WriteLine($"{teststr.IndexOf("the")}");
System.Console.WriteLine($"{teststr.IndexOf("The")}");

// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;
