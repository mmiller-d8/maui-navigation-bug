using NavigationBug.ViewModels;

namespace NavigationBug.Pages;

public partial class Tab2Page : ContentPage
{
    public Tab2ViewModel _viewModel;

    public Tab2Page(Tab2ViewModel viewModel)
	{
		_viewModel = viewModel;
		BindingContext = _viewModel;

		InitializeComponent();
	}
}
