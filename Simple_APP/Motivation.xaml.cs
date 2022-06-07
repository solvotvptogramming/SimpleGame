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
    /// Логика взаимодействия для Motivation.xaml
    /// </summary>
    public partial class Motivation : Page
    {
        private MediaPlayer media1;
        private MediaPlayer mediaPlayer1;
        public Motivation()
        {
            InitializeComponent();
            media1 = new MediaPlayer();
            mediaPlayer1 = new MediaPlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Уилл Смит — Мотивационная речь (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Павел Богрянцев — Лучшая мотивационная речь от Дуэйн «Скала» Джонсона (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В мотивации присутствует ненормативная лексика");
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Мотивационная речь — майк тайсон (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Мотивационная речь (аудио) — Грег Плитт (www.lightaudio.ru).mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\Дензел Вашингтон — Мотивационная речь (www.lightaudio.ru).mp3", UriKind.Absolute));
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
