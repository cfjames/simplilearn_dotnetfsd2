// See https://aka.ms/new-console-template for more information
using Phase4Section1;

Console.WriteLine("Hello, World!");
ICalculator calculator = new Calculator();

//Act
int answer = calculator.Add(5, 19);
