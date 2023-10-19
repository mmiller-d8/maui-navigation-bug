using System;
namespace NavigationBug.ViewModels;

public class Tab1ViewModel : ViewModel
{
	public Tab1ViewModel()
	{
	}

	protected override Task OnNavigateAsync() =>
		NavigateToAsync(GlobalRoutes.Sub1);
}

