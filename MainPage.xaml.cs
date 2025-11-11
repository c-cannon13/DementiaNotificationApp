namespace DementiaNotificationApp
{
    public partial class MainPage : ContentPage
    {
        private bool mBreakfastNotEaten = true;

        public MainPage()
        {
            InitializeComponent();
            InitializeTasks();
            StartNotificationTimer();
        }

        private void InitializeTasks()
        {
            // Example task list
            var tasks = new List<string> { "Eat Breakfast", "Use Bathroom", "Take Medication", "Eat Lunch", "Eat Dinner" };

            foreach (var task in tasks)
            {
                var taskLayout = new StackLayout { Orientation = StackOrientation.Horizontal, Spacing = 15, HorizontalOptions = LayoutOptions.Start  };
                var taskLabel = new Label { Text = task, FontSize = 20, FontAttributes = FontAttributes.Bold, VerticalOptions = LayoutOptions.Center };
                var doneButton = new Button { Text = "Done", FontAttributes = FontAttributes.Bold };

                doneButton.Clicked += ( s, e ) => OnDoneButtonClicked( s, e, taskLayout );

                taskLayout.Children.Add( doneButton );
                taskLayout.Children.Add( taskLabel );

                TaskList.Children.Add( taskLayout );
            }
        }

        private async void OnDoneButtonClicked( object sender, EventArgs e, StackLayout taskLayout )
        {
            bool answer = await DisplayAlert( "Task completed", "Is this task complete?", "Yes", "No" );

            if (answer)
            {
                TaskList.Children.Remove( taskLayout );
            }
        }

        private async void OnHelpButtonClicked( object sender, EventArgs e )
        {
            await Navigation.PushAsync( new HelpPage() );
        }

        private async void OnInfoButtonClicked( object sender, EventArgs e )
        {
            await Navigation.PushAsync( new InfoPage() );
        }

        private void StartNotificationTimer()
        {
            IDispatcherTimer timer = Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromSeconds( 60 );

            timer.Tick += ( s, e ) =>
            {
                if (mBreakfastNotEaten)
                {
                    DisplayAlert( "Notification", "Please eat your breakfast", "Ok" );

                    mBreakfastNotEaten = false;
                }
            };

            timer.Start();
        }
    }
}
