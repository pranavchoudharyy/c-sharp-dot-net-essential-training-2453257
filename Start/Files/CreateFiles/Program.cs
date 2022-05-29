// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream

// using (StreamWriter sw = File.CreateText(filename))
// {
//     sw.WriteLine("Pranav Choudhary");
// }
// System.Console.WriteLine(File.Exists(filename));

// TODO: Determine if a file exists

if(!File.Exists(filename))
{
using (StreamWriter sw = File.CreateText(filename))
{
    sw.WriteLine("Pranav Choudhary");
}
}
else
{
File.Delete(filename);
}
System.Console.WriteLine(File.Exists(filename));