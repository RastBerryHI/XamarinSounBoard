using System;
using Plugin.SimpleAudioPlayer;
using System.Collections.Generic;
using Xamarin.Essentials;
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

            Pashtet.Source = ImageSource.FromResource("ClearApp.Pashtet.jpg");
        }

        // Вибрирование на самых охуенных челов из группы
        private void Vibrate() 
        {
            try
            {
                var duration = TimeSpan.FromSeconds(0.3);
                Vibration.Vibrate(duration);
            }
            catch (FeatureNotSupportedException ex)
            {
                // Вывод в синий лейбл сообщения
                Head.Text = "У вас не поддерживается вибрация";
            }
            catch (Exception ex)
            {
                Head.Text = "Возникла ошибка";
            }
        }

        // Инкапсулированная логика реакции на нажатие
        private void DoResponse(string HeadText, string fileName) 
        {
            
            Head.Text = HeadText;

            // Загрузки и проигрывание мп3
            player.Load(fileName);
            player.Play();
        }

        // Создание объекта для работы с аудиофайлами типа мп3
        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

        // Название функции-события задаётся в атрибуте Clicked в Button
        private void Button_Clicked(object sender, EventArgs e) 
        {
            // Объект для обращения к атрибутам в тэгге <Button></Button>
            Button button = (Button)sender;
            switch (button.ClassId) 
            {
                case "Starosta":
                    {
                        DoResponse(HeadText: "Я потерял журнал", fileName: "Starosta.mp3");
                        Vibrate();
                    }
                    break;
                case "Boss":
                    {
                        DoResponse(HeadText: "Любое слово + Жопа", fileName: "TempMaksim.mp3");
                        Vibrate();
                    }
                    break;
                case "Tema":
                    {
                        DoResponse(HeadText: "Обогреватель в общаге 24/7", fileName: "Artem.mp3");
                    }
                    break;
                case "Kentavr":
                    {
                        DoResponse(HeadText: "Кори Тейлор просто Хурма блядь", fileName: "KENTavr.mp3");
                        Vibrate();
                    }
                    break;
                case "Fish":
                    {
                        DoResponse(HeadText: "Хакер трубы чистил и так стал чёрным", fileName: "Fish.mp3");
                    }
                    break;
                case "Egor":
                    {
                        DoResponse(HeadText: "Мелочь тоже деньги", fileName: "Egor.mp3");
                    }
                    Vibrate();
                    break;
                case "Nikita":
                    {
                        DoResponse(HeadText: "Та я просто дungeon master", fileName: "Nikita.mp3");
                    }
                    break;
                case "Yaroslaw":
                    {
                        DoResponse(HeadText: "Господа, кажется вы недооценили виноград", fileName: "Yarik.mp3");
                    }
                    break;
            }
        }
    }
}