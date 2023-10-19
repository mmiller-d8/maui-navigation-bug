using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NavigationBug.ViewModels;

public partial class ViewModel : ObservableObject, IQueryAttributable 
{
    protected IDictionary<string, object> RouteParameters { get; private set; }

	public ViewModel()
	{
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("x"))
            query.Remove("x");

        RouteParameters = query;
    }

    [RelayCommand]
    private Task NavigateAsync() => OnNavigateAsync();

    protected virtual Task OnNavigateAsync() => Task.CompletedTask;


    protected Task NavigateToShellAsync(string route, IDictionary<string, object> routeParameters = null) =>
        NavigateToAsync(ShellNavigationPrefixes.DownwardsReplace, route, routeParameters);

    protected Task NavigateToAsync(string navigationPrefix, string route, IDictionary<string, object> routeParameters = null) =>
        NavigateToAsync($"{navigationPrefix}{route}", routeParameters);

    protected virtual async Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
    {
        await InvokeOnMainThreadAsync(async () =>
        {
            IDictionary<string, object> parameters;

            // ApplyQueryAttributes won't fire if the dictionary is null or empty
            if (routeParameters == null)
                parameters = new Dictionary<string, object>() { { "x", "" } };
            else
                parameters = routeParameters;

            await Shell.Current.GoToAsync(route, true, parameters);
        });
    }

    private void InvokeOnMainThread(Action action)
    {
        if (MainThread.IsMainThread)
            action.Invoke();
        else
            MainThread.BeginInvokeOnMainThread(() => action.Invoke());
    }

    private async Task InvokeOnMainThreadAsync(Func<Task> function)
    {
        if (MainThread.IsMainThread)
            await function.Invoke();
        else
            await MainThread.InvokeOnMainThreadAsync(function);
    }
}

