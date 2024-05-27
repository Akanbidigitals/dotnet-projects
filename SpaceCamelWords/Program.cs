using SpaceCamelWords.Action;

var runProgram = new Start();

var result = runProgram.SplitCamelCase("thisIsProgrammingLanguage");
Console.WriteLine(result);