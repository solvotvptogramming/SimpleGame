using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Simple_APP
{
    /// <summary>
    /// Логика взаимодействия для Cavers.xaml
    /// </summary>
    public partial class Cavers : Page
    {
        private MediaPlayer media1;
        private MediaPlayer mediaPlayer1;
        public Cavers()
        {
            InitializeComponent();
            media1 = new MediaPlayer();
            mediaPlayer1 = new MediaPlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Звуки — Страшные. (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\страшный звук... — его боятся все. (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Ночь с бабайкой — Самый страшный звук (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\SIREN HEAD — ЗВУКИ КОТОРЫЕ ИЗДАЁТ СИРЕНОГОЛОВЫЙ (bassboosted by retardbot, gain_ 30dB) (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Страшная Музыка!.mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Stop();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            mediaPlayer1.Stop();
        }
    }
}
