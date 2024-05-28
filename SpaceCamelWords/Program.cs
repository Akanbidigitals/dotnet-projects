using SpaceCamelWords.Action;


Console.WriteLine("---Welcome to convert to camel space");

string input = Console.ReadLine();

var runProgram = new Start();

var result = runProgram.SplitCamelCase(input);
Console.WriteLine(result);