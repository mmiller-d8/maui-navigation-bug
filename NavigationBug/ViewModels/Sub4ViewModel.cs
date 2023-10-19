using System;
namespace NavigationBug.ViewModels;

public class Sub4ViewModel : ViewModel
{
    public Sub4ViewModel()
    {
    }

    protected override async Task OnNavigateAsync()
    {
        await DoSomethingAsync();
        await DoSomethingElseAsync();

        await NavigateToShellAsync(ShellRoutes.Start);
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

