// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time

// System.Console.WriteLine(DateTime.Now);

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
// System.Console.WriteLine(DateTime.Today);

// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
TimeOnly tt = TimeOnly.FromDateTime(DateTime.Now);
System.Console.WriteLine(dt);
System.Console.WriteLine(tt);

// TODO: Dates have properties that can be inspected
DateTime Today = DateTime.Now;
System.Console.WriteLine(Today.DayOfWeek);
System.Console.WriteLine(Today.DayOfYear);

// TODO: Dates also have methods to change their values
System.Console.WriteLine($"{Today.AddDays(5)}");

// TODO: The TimeSpan class represents a duration of time
DateTime now = DateTime.Now;
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan ts = AprilFools - NewYears;
System.Console.WriteLine(ts);

// TODO: Dates can be compared using regular operators
System.Console.WriteLine($"{AprilFools > NewYears}");