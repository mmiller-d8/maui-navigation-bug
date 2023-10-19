using NavigationBug.ViewModels;

namespace NavigationBug.Pages;

public partial class Sub1Page : ContentPage
{
	private Sub1ViewModel _viewModel;

	public Sub1Page(Sub1ViewModel viewModel)
	{
		_viewModel = viewModel;
		BindingContext = _viewModel;

		InitializeComponent();
	}
}
