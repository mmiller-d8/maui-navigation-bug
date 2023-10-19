using NavigationBug.ViewModels;

namespace NavigationBug.Pages;

public partial class Tab1Page : ContentPage
{
	public Tab1ViewModel _viewModel;

	public Tab1Page(Tab1ViewModel viewModel)
	{
		_viewModel = viewModel;
		BindingContext = _viewModel;

		InitializeComponent();
	}
}
