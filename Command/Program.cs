using System;
using System.Collections.Generic;

namespace Command
{
	class Program
	{
		//https://refactoring.guru/ru/design-patterns/command
		//https://ru.wikipedia.org/wiki/%D0%9A%D0%BE%D0%BC%D0%B0%D0%BD%D0%B4%D0%B0_(%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD_%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F)
		static void Main(string[] args)
		{
			var commandHistory = new Stack<CalculatorCommand>();

			var calculator = new Calculator();

			var commandList = new List<CalculatorCommand>() {
				new CalculatorCommand(calculator, 10, '+'),
				new CalculatorCommand(calculator, 4, '*'),
				new CalculatorCommand(calculator, 30, '-'),
				new CalculatorCommand(calculator, 0, '/'),
				new CalculatorCommand(calculator, 20, '-')
			};

			foreach (var command in commandList)
			{
				command.Execute();
				Console.WriteLine($"Current Value: {calculator.Current};");
				commandHistory.Push(command);
			}

			commandHistory.Pop().Undo();
			Console.WriteLine($"Undo the last operation: Value: {calculator.Current}");

			commandHistory.Pop().Undo();
			Console.WriteLine($"Undo one more: Value: {calculator.Current}");

			commandHistory.Pop().Undo();
			Console.WriteLine($"Undo and one more operation: Value: {calculator.Current}");

			Console.Read();
		}
	}
}
