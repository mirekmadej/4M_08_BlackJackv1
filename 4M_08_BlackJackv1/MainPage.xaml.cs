namespace _4M_08_BlackJackv1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnNowaClicked(object sender, EventArgs e)
        {
            btnGraj.IsVisible = true;
            btnNowa.IsVisible = false;
        }
        private void btnGrajClicked(object sender, EventArgs e)
        {
            btnGraj.IsVisible = false;
            btnNowa.IsVisible = true;
        }
    }
}