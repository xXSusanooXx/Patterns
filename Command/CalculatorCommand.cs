using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
	class CalculatorCommand : ICommand
	{
		private double operand;
		private char @operator;
		private Calculator calculator;
		private IMemento backup;

		public CalculatorCommand(Calculator calculator, double operand, char @operator)
		{
			this.calculator = calculator;
			this.operand = operand;
			this.@operator = @operator;
		}

		public void Execute()
		{
			this.backup = calculator.GetState();
			this.calculator.Operation(operand, @operator);
		}

		public void Undo()
		{
			this.backup.RestoreState();
		}
	}
}
