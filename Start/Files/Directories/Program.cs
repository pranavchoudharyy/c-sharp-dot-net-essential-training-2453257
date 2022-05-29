// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
// if(!Directory.Exists(dirname)){
//     Directory.CreateDirectory(dirname);
// }
// else{
// Directory.Delete(dirname);
// }
string curPath = Directory.GetCurrentDirectory();
// TODO: Get the path for the current directory
// System.Console.WriteLine(Directory.GetCurrentDirectory());

// TODO: Just like with files, you can retrieve info about a directory
// DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
// System.Console.WriteLine($"{di.CreationTime}");

// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curPath));
foreach(string dir in thedirs)
{
System.Console.WriteLine(dir);
}
// Console.WriteLine("---------------");

// Console.WriteLine("Just files:");

// Console.WriteLine("---------------");

// Console.WriteLine("All directory contents:");
