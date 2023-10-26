namespace _4M_08_BlackJackv1
{
    public partial class MainPage : ContentPage
    {
        private string[] talia = new string[52];
        private int pK, pKas, pG, pGas;
        public MainPage()
        {
            InitializeComponent();
            generujTalie();
        }
        private void generujTalie()
        {           
            string[] kolory = { "Pik", "Kier", "Karo", "Trefl" };
            int poz = 0;
            for (int i = 0; i < kolory.Length; i++)
            {
                talia[poz++] = "A " + kolory[i];
                for (int j = 2; j <= 10; j++)
                    talia[poz++] = j.ToString() + " " + kolory[i];
                talia[poz++] = "W " + kolory[i];
                talia[poz++] = "D " + kolory[i];
                talia[poz++] = "K " + kolory[i];
            }
            pK = pKas = pG = pGas = 0;
        }

        private void btnNowaGraClicked(object sender, EventArgs e)
        {
            generujTalie();
            /*    1. ukryć ten button
             *    2. pokazać przycisk dobierz i pass
             *    3. wylosować karty dla krupiera, obliczyć wyniki
             *    4. wylosować karty dla gracza, obliczyć wuniki 
             *    5. wyswietlić wyniki gracza
             */  
        }
        private void btnDobierzClicked(object sender, EventArgs e)
        {
            
        }
        private void btnPassClicked(object sender, EventArgs e)
        {

        }
    }
}