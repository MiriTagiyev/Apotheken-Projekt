// Aptek layihesi -> isci terefi
// Login hissesi
// Bir menyu olsun
// 1. Dermanlarin siyahisi
// 2. Derman elave etmek
// 3. Derman silmek
// 4. Derman axtarmaq

// 5. Yeni isci elave et

// Derman -> Maye, Tabletka
using Lesson10;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string email = "admin@mail.com";
string pass = "admin123";

Console.WriteLine("Emailinizi daxil edin: ");
string iEmail = Console.ReadLine();
Console.WriteLine("Şifrənizi daxil edin: ");
string iPass = Console.ReadLine();

if (email == iEmail && pass == iPass)
{
	PrintMessage("Sisteme giris edildi", ConsoleColor.Green);
	var aptek = new Aptek("Shefa", 10);
	bool isRunning = true;

	do
	{
		Thread.Sleep(2000);
		Console.Clear();
		Console.WriteLine($"Salam, {aptek.AptekAdi} apteke xos gelmisiniz, asagidan bir emeliyyat secin: ");
		Console.WriteLine("1. Dermanlarin siyahisi");
		Console.WriteLine("2. Derman elave etmek");
		Console.WriteLine("3. Derman silmek");
		Console.WriteLine("4. Derman axtarmaq");
		Console.WriteLine("5. Cixis");

		int secim = Convert.ToInt32(Console.ReadLine());

		switch (secim)
		{
			// Dermanlarin siyahisi
			case 1:
				aptek.DermanlariGoster();
				break;
			// Derman elave etmek
			case 2:
				{
					//aptek.DermanElaveEt();
					Console.WriteLine("Hansi tip derman elave edeceksiniz?");
					Console.WriteLine("1. Maye");
					Console.WriteLine("2. Tablet");
					int dermanSecim = Convert.ToInt32(Console.ReadLine());
					switch (dermanSecim)
					{
						// Maye derman
						case 1:
							{
								Console.WriteLine("Dermanin adini daxil edin: ");
								var ad = Console.ReadLine();
								Console.WriteLine("Qiymeti daxil edin: ");
								var qiymet = Convert.ToDouble(Console.ReadLine());
								Console.WriteLine("Ili daxil edin");
								var il = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine("Ayi daxil edin");
								var ay = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine("Gunu daxil edin");
								var gun = Convert.ToInt32(Console.ReadLine());
								var istehsalTarixi = new DateTime(il, ay, gun);
								Console.WriteLine("Hecmi daxil edin");
								var hecm = Convert.ToInt32(Console.ReadLine());
								var derman = new MayeDerman()
								{
									Ad = ad,
									Qiymet = qiymet,
									IstehsalTarixi = istehsalTarixi,
									Hecm = hecm
								};

								var netice = aptek.DermanElaveEt(derman);
								if (netice)
									PrintMessage("Ugurla elave edildi", ConsoleColor.Green);
								else
									PrintMessage("Bir xeta bas verdi", ConsoleColor.Red);
							}
							break;
						// Tablet derman
						case 2:
							{
								Console.WriteLine("Dermanin adini daxil edin: ");
								var ad = Console.ReadLine();
								Console.WriteLine("Qiymeti daxil edin: ");
								var qiymet = Convert.ToDouble(Console.ReadLine());
								Console.WriteLine("Ili daxil edin");
								var il = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine("Ayi daxil edin");
								var ay = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine("Gunu daxil edin");
								var gun = Convert.ToInt32(Console.ReadLine());
								var istehsalTarixi = new DateTime(il, ay, gun);
								Console.WriteLine("Sayi daxil edin");
								var say = Convert.ToInt32(Console.ReadLine());
								var derman = new TabletDerman()
								{
									Ad = ad,
									Qiymet = qiymet,
									IstehsalTarixi = istehsalTarixi,
									Sayi = say
								};

								var netice = aptek.DermanElaveEt(derman);
								if (netice)
									PrintMessage("Ugurla elave edildi", ConsoleColor.Green);
								else
									PrintMessage("Bir xeta bas verdi", ConsoleColor.Red);
							}
							break;
						default:
							PrintMessage("Bele bir secim yoxdur", ConsoleColor.Red);
							break;
					}

					break;
				}
			// Derman silmek
			case 3:
				{
					aptek.DermanlariGoster();
					Console.WriteLine("Sileceyiniz dermani secin: ");
					int dermanNomresi = Convert.ToInt32(Console.ReadLine()) - 1;
					var netice = aptek.DermanSilmek(dermanNomresi);
					if (netice)
						PrintMessage("Ugurla silindi", ConsoleColor.Green);
					else
						PrintMessage("Bir xeta bas verdi", ConsoleColor.Red);
					break;
				}
			// Derman axtarmaq
			case 4:
				{
					Console.WriteLine("Adi daxil edin(istemirsinizse entere basin): ");
					var ad = Console.ReadLine();
					Console.WriteLine("Qiymeti daxil edin(istemirsinizse entere basin): ");
					double.TryParse(Console.ReadLine(), out double qiymet);
					Console.WriteLine("Tipi daxil edin(Maye ve ya Tablet)");
					var tip = Console.ReadLine();
					aptek.DermanAxtar(ad, qiymet, tip);
					break;
				}
			// Cixis
			case 5:
				Console.WriteLine("Aptekimizi ziyaret etdiyiniz ucun tesekkurler 👋");
				isRunning = false;
				break;
			default:
				PrintMessage("Bele bir secim yoxdur", ConsoleColor.Red);
				break;
		}
	} while (isRunning);

}
else
{
	PrintMessage("Xeta! Istifadeci adi ve ya sifre yanlisdir", ConsoleColor.Red);
}



void PrintMessage(string message, ConsoleColor color = ConsoleColor.Blue)
{
	Console.ForegroundColor = color;
	Console.WriteLine(message);
	Console.ResetColor();
}