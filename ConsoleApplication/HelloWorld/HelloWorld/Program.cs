// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello\nWorld!"); // New line
Console.WriteLine("Hello\tWorld!"); // Tab
Console.WriteLine("Hello \"World\"!"); // Quotes
Console.WriteLine("c:\\source\\repos"); // Backslash
*/

Console.WriteLine("Generating invoices for Customer \"Consto Corp\"... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// Kon'nichiwa World
Console.WriteLine("\n\u3053\u3093\u306B\u3061\u306F World!");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:  UTF-16
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");