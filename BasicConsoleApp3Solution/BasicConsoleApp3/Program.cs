using
 BasicConsoleApp3;

Console.WriteLine("Enter your first name: ");
string first =  Console.ReadLine();
Console.WriteLine("Enter your last name: ");
string last = Console.ReadLine();




string full = Formatters.FormatName(first, last);
Console.WriteLine($"Hello, {full}");