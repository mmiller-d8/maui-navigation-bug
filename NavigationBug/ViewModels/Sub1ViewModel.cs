using System;
namespace NavigationBug.ViewModels;

public class Sub1ViewModel : ViewModel 
{
	public Sub1ViewModel()
	{
	}

    protected override Task OnNavigateAsync() =>
        NavigateToAsync(GlobalRoutes.Sub2);
}

