namespace Lesson10
{
	public abstract class Derman
	{
		public string Ad { get; set; }
		public double Qiymet { get; set; }
		public DateTime IstehsalTarixi { get; set; }

		public abstract string TipGonder();
	}
}
