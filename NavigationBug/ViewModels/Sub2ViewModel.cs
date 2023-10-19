using System;
namespace NavigationBug.ViewModels;

public class Sub2ViewModel : ViewModel
{
	public Sub2ViewModel()
	{
	}

    protected override Task OnNavigateAsync() =>
        NavigateToAsync(GlobalRoutes.Sub3);
}

