using System;
namespace NavigationBug.ViewModels;

public class StartViewModel : ViewModel
{
	public StartViewModel()
	{
	}

    protected override Task OnNavigateAsync() =>
        NavigateToShellAsync(ShellRoutes.Tab1);
}

