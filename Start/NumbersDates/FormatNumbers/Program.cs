﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting numerical data in .NET

int[] quarters = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
// System.Console.WriteLine($"{val1:N} {val1:D} {val1:F} {val1:G} ");
// System.Console.WriteLine($"{val2:N} {val2:F1} {val2:G} {val2:E} ");


// // TODO: Add a number after the format to specify precision
// System.Console.WriteLine($"{val1:N2} {val1:D6} {val1:F3} {val1:G2} ");

// TODO: Formatting with alignment and spacing
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0], 12} {quarters[1], 12} {quarters[2] ,12} {quarters[3], 12}");
Console.WriteLine($"{sales[0], 12:C} {sales[1], 12:C} {sales[2], 12:C} {sales[3], 12:C}");
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0], 12:P1} {intlMixPct[1], 12:P0} {intlMixPct[2], 12:P0} {intlMixPct[3], 12:P2}");
