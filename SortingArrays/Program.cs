using SortingArrays.Models;

int[] input = { 5, 6, 8, 0, 10, 15, 32, 78, 23 };

var sortArr = new Start();

int[] result = sortArr.SortArrays(input);

    Console.WriteLine("Ascending Order");
foreach (int i in result)
{

    Console.WriteLine($"num : {i}");
}
