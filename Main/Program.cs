using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Hello, World!");

var clonedInvariantCulture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
//clonedInvariantCulture.DateTimeFormat.Calendar.TwoDigitYearMax = 2039; // Use any desired cutoff value.

var dt = DateTime.Parse("12/25/45", clonedInvariantCulture);
var dt2 = DateTime.Parse("12/25/35", clonedInvariantCulture);
Console.WriteLine(dt.ToString());
Console.WriteLine(dt2.ToString());

CultureInfo.CurrentCulture = new CultureInfo("es-ES");
Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture}");

var cultureInfoExampleDateTime = new DateTime(2022, 8, 1);

var frCulture = new CultureInfo("fr-FR");
frCulture.DateTimeFormat.ShortDatePattern = "dd MMMM yyyy";

Console.WriteLine(TypeDescriptor.GetConverter(cultureInfoExampleDateTime).ConvertTo(null, frCulture, cultureInfoExampleDateTime, typeof(string)));

var timeonly = new TimeOnly(10, 14, 15);
Console.WriteLine(timeonly.ToString());