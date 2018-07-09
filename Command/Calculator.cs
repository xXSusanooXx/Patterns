using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
	class Calculator
	{
		public double Current { get; private set; } = 0;
		public void Operation(double operand, char @operator)
		{
			switch (@operator)
			{
				case '+': Current += operand; break;
				case '-': Current -= operand; break;
				case '*': Current *= operand; break;
				case '/':
					{
						if (operand == 0)
						{
							throw new ArgumentException("Devision by zero is forbidden");
						}

						Current /= operand; break;
					}
			}
		}

		public IMemento GetState()
		{
			return new CalculatorMomento(this);
		}

		private class CalculatorMomento : IMemento
		{
			private double current;
			private Calculator calculator;

			public CalculatorMomento(Calculator calculator)
			{
				this.calculator = calculator;
				this.current = calculator.Current;
			}

			public void RestoreState()
			{
				this.calculator.Current = this.current;
			}
		}
	}
}
