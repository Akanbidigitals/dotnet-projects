using ReverseWordMoreThan5Letters.Model;


Console.WriteLine("Welcome to Reverse 5 letters above words");

Console.WriteLine("-----------------------------------------");

Console.WriteLine("Pls enter your words");

string input = Console.ReadLine();

var validate = new Start();


var result = validate.ReverseWordWith5Letters(input);

Console.WriteLine(result);

