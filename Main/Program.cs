using System.Globalization;

Console.WriteLine("Hello, World!");

CultureInfo clonedInvariantCulture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
clonedInvariantCulture.DateTimeFormat.Calendar.TwoDigitYearMax = 2039; // Use any desired cutoff value.

DateTime dt = DateTime.Parse("12/25/45", clonedInvariantCulture);
DateTime dt2 = DateTime.Parse("12/25/35", clonedInvariantCulture);
Console.WriteLine(dt.ToString());
Console.WriteLine(dt2.ToString());