using NavigationBug.ViewModels;

namespace NavigationBug.Pages;

public partial class Sub3Page : ContentPage
{
	private readonly Sub3ViewModel _viewModel;

	public Sub3Page(Sub3ViewModel viewModel)
	{
		_viewModel = viewModel;
		BindingContext = _viewModel;

		InitializeComponent();
	}
}
