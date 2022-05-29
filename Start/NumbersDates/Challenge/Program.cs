System.Console.WriteLine("Which date ? or 'exit'");
String input = System.Console.ReadLine();
if(input!="exit")
{
    DateTime InputDate;
    DateTime now = DateTime.Today;
    TimeSpan ts;
    if(DateTime.TryParse(input,out InputDate))
    {
        if(InputDate>now)
        {
            ts = InputDate - now;
            System.Console.WriteLine($"That Date will be {ts.Days} days!");
        }
        if(InputDate < now)
        {
            ts = now - InputDate;
            System.Console.WriteLine($"That Date went by {ts.Days} days ago!");
        }

        if(InputDate==now)
        {
            System.Console.WriteLine("That Date is today!");
        }
    }
    else
    {
        System.Console.WriteLine("That doesn't seem to be a valid date");
    }
}
else
{
System.Console.WriteLine("Program Exits!!");
}