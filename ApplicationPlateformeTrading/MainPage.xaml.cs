using ApplicationPlateformeTrading.Modele;

namespace ApplicationPlateformeTrading
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            trader TRAD1 = new trader( "Lidell","Alice",new DateTime(1990,01,01),"F", "alice@example.com", 1234567890);
            trader TRAD2 = new trader("Bob", "Marley", new DateTime(1985,05,11), "M", "bob@example.com", 0987654321);


            action Actionnaire1 = new action("US0378331005","Apple",150-000);
            action Actionnaire2 = new action("US5949181045", "MIcrosoft",200-000);

            



        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}