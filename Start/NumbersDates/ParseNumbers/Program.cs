// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing numerical data from strings

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
// foreach (string str in NumStrs) 
// {
//     try
//     {
        
//         testfloat = float.Parse(str);
//         System.Console.WriteLine($"Float : {testfloat}");
//         testint = int.Parse(str);
//         System.Console.WriteLine(testint);
        

//     }
//     catch(FormatException e)
//     {
//         System.Console.WriteLine($"{str} is not parsed , Exception is : {e.Message}");
//     }

// }

// TODO: The TryParse method returns 'true' if the parse is successful
result = int.TryParse(NumStrs[0], out testint);
System.Console.WriteLine(result);
result = int.TryParse(NumStrs[1], out testint);
System.Console.WriteLine(result);
result = int.TryParse(NumStrs[2], out testint);
System.Console.WriteLine(result);
result = int.TryParse(NumStrs[3], out testint);
System.Console.WriteLine(result);