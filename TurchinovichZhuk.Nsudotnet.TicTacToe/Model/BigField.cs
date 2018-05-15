namespace TurchinovichZhuk.Nsudotnet.TicTacToe.Model
{
	class BigField
	{
		private SmallField[] _smallFields;

		public SmallField[] SmallFields
		{
			get { return _smallFields; }
			set { _smallFields = value; }
		}

		public BigField(SmallField[] smallFields)
		{
			_smallFields = smallFields;
		}

	}
}
