using MauiApp1;

namespace Pages_Demo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ContentPageDemo();
	}
}
