namespace DementiaNotificationApp;

public partial class InfoPage : ContentPage
{
    private static string mFirstName = "";
    private static string mLastName = "";
    private static string mCarersFirstName = "";
    private static string mCarersLastName = "";
    private static string mCarersNumber = "";

    public InfoPage()
	{
		InitializeComponent();
        InitializeData();
	}

    private void InitializeData()
    {
        FirstName.Text = mFirstName;
        LastName.Text = mLastName;
        CarersFirstName.Text = mCarersFirstName;
        CarersLastName.Text = mCarersLastName;
        CarersNumber.Text = mCarersNumber;
    }

    private async void OnHelpButtonClicked( object sender, EventArgs e )
    {
        await Navigation.PushAsync( new HelpPage() );
    }

    private async void OnBackButtonClicked( object sender, EventArgs e )
    {
        await Navigation.PushAsync( new MainPage() );
    }

    private async void OnSaveButtonClicked( object sender, EventArgs e )
    {
        if (Password.Text != "password")
        {
            await DisplayAlert( "Error - Incorrect Password", "Enter the correct carer's password", "Ok" );

            return;
        }

        bool answer = await DisplayAlert( "Confirm Save", "Are you sure you want to save?", "Yes", "No" );

        if (answer)
        {
            mFirstName = FirstName.Text;
            mLastName = LastName.Text;
            mCarersFirstName = CarersFirstName.Text;
            mCarersLastName = CarersLastName.Text;
            mCarersNumber = CarersNumber.Text;

            await Navigation.PushAsync( new MainPage() );
        }
    }
}