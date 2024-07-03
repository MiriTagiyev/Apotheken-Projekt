namespace Lesson10
{
	public class MayeDerman : Derman
	{
		public int Hecm { get; set; }

		public override string TipGonder()
		{
			return "Maye";
		}

		public override string ToString()
		{
			return $"Tip: Maye, {Ad}, {Qiymet}, {IstehsalTarixi}, {Hecm}";
		}
	}
}
