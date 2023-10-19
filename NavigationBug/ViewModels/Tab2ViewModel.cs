using System;
namespace NavigationBug.ViewModels;

public class Tab2ViewModel : ViewModel
{
	public Tab2ViewModel()
	{
	}

    protected override Task OnNavigateAsync() =>
        NavigateToAsync(GlobalRoutes.Sub1);
}

