using System;
namespace NavigationBug.ViewModels;

public class Sub3ViewModel : ViewModel
{
	public Sub3ViewModel()
	{
	}

    protected override async Task OnNavigateAsync()
	{
		await DoSomethingAsync();
		await DoSomethingElseAsync();

		await NavigateToAsync(GlobalRoutes.Sub4);
	}

	private async Task DoSomethingAsync()
	{
		await Task.Delay(200);
	}

	private async Task DoSomethingElseAsync()
	{
		await Task.Delay(200);
	}

}

