// See https://aka.ms/new-console-template for more information
using MathOperationsApp;

ResultDisplay resultDisplay = new ResultDisplay();
MathOperations mathOperations = new MathOperations();
resultDisplay.Subscribe(mathOperations);
mathOperations.Add(10, 5);
mathOperations.Subtract(10, 5);
mathOperations.Multiply(10, 5);
mathOperations.Divide(10, 5);  