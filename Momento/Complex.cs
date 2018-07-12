namespace Momento
{
	public class Complex : IMementable
	{
		public double R { get; set; }

		public double I { get; set; }

		public IMemento GetMemento()
		{
			return new ComplexMemento(this);
		}

		public class ComplexMemento : IMemento
		{
			private readonly Complex backup;

			public double R { get; private set; }

			public double I { get; private set; }

			public ComplexMemento(Complex complex)
			{
				this.backup = complex;
				this.R = complex.R;
				this.I = complex.I;
			}

			public void RestoreState()
			{
				this.backup.R = this.R;
				this.backup.I = this.I;
			}
		}
	}
}
