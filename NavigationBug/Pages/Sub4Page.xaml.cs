using NavigationBug.ViewModels;

namespace NavigationBug.Pages;

public partial class Sub4Page : ContentPage
{
    private readonly Sub4ViewModel _viewModel;

    public Sub4Page(Sub4ViewModel viewModel)
	{
		_viewModel = viewModel;
		BindingContext = _viewModel;

		InitializeComponent();
	}
}
