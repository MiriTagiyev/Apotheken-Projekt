namespace Lesson10
{
	public class Aptek
	{
		public string AptekAdi { get; set; }
		private Derman[] _dermanlar;

		public Aptek(string aptekAdi, int dermanSayi = 1)
		{
			AptekAdi = aptekAdi;
			_dermanlar = new Derman[dermanSayi];
		}

		public void DermanlariGoster()
		{
			int count = 1;
			foreach (var derman in _dermanlar)
			{
				if (derman is null)
					continue;

				Console.Write($"{count})");
				Console.WriteLine(derman);
				count++;
			}
		}

		public void DermanAxtar(string ad = "", double qiymet = 0.0, string tip = "")
		{
			foreach (var derman in _dermanlar)
			{
				if (derman is null)
					continue;

				if (derman.Ad == ad || derman.Qiymet == qiymet || derman.TipGonder() == tip)
				{
					Console.WriteLine(derman);
				}
			}
		}

		public bool DermanElaveEt(Derman derman)
		{

			for (int i = 0; i < _dermanlar.Length; i++)
			{
				if (_dermanlar[i] is null)
				{
					_dermanlar[i] = derman;
					return true;
				}
			}

			_dermanlar = _dermanlar.Append(derman).ToArray();

			return true;
		}

		public bool DermanSilmek(int index)
		{
			if (index < 0 || index >= _dermanlar.Length)
				return false;

			var _yeniDermanlar = _dermanlar.ToList();

			_yeniDermanlar.RemoveAt(index);

			_dermanlar = _yeniDermanlar.ToArray();

			return true;
		}
	}
}
