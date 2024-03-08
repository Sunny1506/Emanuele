using Microsoft.Maui.Controls;

namespace Projeto;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
private void ButtonStartButtonClicked (object sender, EventArgs args)
{
 if (Application.Current !=null)
   Application.Current.MainPage = new GamePage();	
}
private void ButtonAboutButtonClicked(object sender, EventArgs args)
{
	  frameAbout.IsVisible = true;
}

private void ButtonDimissButtonClicked(object sender, EventArgs args)
{
	frameAbout.IsVisible= false;
}
}

