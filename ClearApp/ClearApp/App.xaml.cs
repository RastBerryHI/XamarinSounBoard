using Xamarin.Forms;
using ClearApp.Views;


namespace ClearApp
{
   
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();

            // Страница отображающаяся при открытии приложения
            MainPage = new Buttons();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
