using NavigationBug.Pages;

namespace NavigationBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


		Routing.RegisterRoute(GlobalRoutes.Sub1, typeof(Sub1Page));
		Routing.RegisterRoute(GlobalRoutes.Sub2, typeof(Sub2Page));
		Routing.RegisterRoute(GlobalRoutes.Sub3, typeof(Sub3Page));
        Routing.RegisterRoute(GlobalRoutes.Sub4, typeof(Sub4Page));
    }
}

