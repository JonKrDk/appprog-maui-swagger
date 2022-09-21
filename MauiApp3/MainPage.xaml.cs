namespace MauiApp3;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		ClassLibrary1.ApiClient client = new ClassLibrary1.ApiClient("http://kartotek.kodeknud.dk", new HttpClient());

		IEnumerable<ClassLibrary1.Person> list = client.PeopleAllAsync().Result;

		myLabel.Text = "";
		foreach (ClassLibrary1.Person person in list)
		{
			myLabel.Text += person.FirstName + " "; ;	
		}
	}
}

