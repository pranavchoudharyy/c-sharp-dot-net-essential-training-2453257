// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) 
{
    using(StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("Pranav Choudhary");
    }
}
// File.WriteAllText(filename, "Pranav");

// TODO 3: AppendAllText adds text to an existing file

// File.AppendAllText(filename," Choudhary is added now");

// TODO 4: A FileStream can be opened and written to until closed

// using(StreamWriter sw = File.AppendText(filename)){
//     sw.WriteLine("hello");
//     sw.WriteLine("hello 1");
// }

// TODO 2: ReadAllText reads all the content from a file
Console.WriteLine(File.ReadAllText(filename));
