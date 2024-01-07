using System;
using Proiect_Farcas_Gherghelas_mobil.Data;
using System.IO;

namespace Proiect_Farcas_Gherghelas_mobil;

public partial class App : Application
{
	static PartiiDatabase database;

	public static PartiiDatabase Database
	{
		get
		{
			if (database ==null)
			{
				database = new PartiiDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PartiiDatabase.db3"));
			}
			return database;
		}
	}

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
