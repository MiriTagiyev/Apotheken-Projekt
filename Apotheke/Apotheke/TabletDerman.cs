namespace Lesson10
{
	public class TabletDerman : Derman
	{
		public int Sayi { get; set; }

		public override string TipGonder()
		{
			return "Tablet";
		}

		public override string ToString()
		{
			return $"Tip: Tablet, {Ad}, {Qiymet}, {IstehsalTarixi}, {Sayi}";
		}
	}
}
