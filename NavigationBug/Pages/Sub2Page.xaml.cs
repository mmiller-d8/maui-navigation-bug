using NavigationBug.ViewModels;

namespace NavigationBug.Pages;

public partial class Sub2Page : ContentPage
{
	private readonly Sub2ViewModel _viewModel;

	public Sub2Page(Sub2ViewModel viewModel)
	{
		_viewModel = viewModel;
		BindingContext = _viewModel;

		InitializeComponent();
	}
}
