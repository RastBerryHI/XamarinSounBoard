using System;
using Plugin.SimpleAudioPlayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// Класс в котором реализуются функции для кнопок

/*!!!ВАЖНО: ВСЕ АУДИОФАЙЛЫ ПОМЕЩАЮТСЯ ТОЛЬКО В ClearApp.Android.Assets!!!*/

namespace ClearApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttons : ContentPage
    {
        
        public Buttons()
        {
            InitializeComponent();
        }

        // Создание объекта для работы с аудиофайлами типа мп3
        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

        // Название функции-события задаётся в атрибуте Clicked в Button
        private void Button_Clicked(object sender, EventArgs e) 
        {
            // Поле текста label (Голубое поле сверху кнопок)
            Head.Text = "Нихуя ты придумал";

            // Загрузки и проигрывание мп3
            player.Load("Starosta.mp3");
            player.Play();
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            Head.Text = "Король Белого Трона";

            player.Load("TempMaksim.mp3");
            player.Play();
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            Head.Text = "Лупа и Пупа = Минус компутер";

            player.Load("Artem.mp3");
            player.Play();
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            Head.Text = "Хакер в одни ворота";

            player.Load("Fish.mp3");
            player.Play();
        }

        private void Button_Clicked5(object sender, EventArgs e)
        {
            Head.Text = "Мелочь тоже деньги";

            player.Load("Egor.mp3");
            player.Play();
        }

        private void Button_Clicked6(object sender, EventArgs e)
        {
            Head.Text = "Кто нахуй? Ты нахуй? Я нахуй!?";

            player.Load("Nikita.mp3");
            player.Play();
        }

    }
}