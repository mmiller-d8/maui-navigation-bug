using NavigationBug.ViewModels;

namespace NavigationBug.Pages;

public partial class StartPage : ContentPage
{
	private readonly StartViewModel _viewModel;

	public StartPage(StartViewModel viewModel)
	{
		_viewModel = viewModel;
		BindingContext = _viewModel;

		InitializeComponent();
	}
}
