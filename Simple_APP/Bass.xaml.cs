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
    /// Логика взаимодействия для Bass.xaml
    /// </summary>
    public partial class Bass : Page
    {
        private MediaPlayer media1;
        private MediaPlayer mediaPlayer1;
        public Bass()
        {
            InitializeComponent();
            media1 = new MediaPlayer();
            mediaPlayer1 = new MediaPlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\GHOSTEMANE - Mercury Retrograde.mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Prorok — САМЫЙ МОЩНЫЙ БАСС В МИРЕ [3]!!! 🚫 (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\❗𝔻𝕆𝕃𝔹𝕀𝕋 ℕ𝕆ℝ𝕄𝔸𝕃ℕ𝕆❗ — 🔞МОЩНЫЙ БАСС #2🔞 (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\RNJ — САМЫЙ МОЩНЫЙ БАСС В МИРЕ #10 (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Mihailenko — Басс #4 (www.lightaudio.ru).mp3", UriKind.Absolute));
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
