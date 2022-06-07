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
    /// Логика взаимодействия для Gold_island.xaml
    /// </summary>
    public partial class Gold_island : Page
    {
        private MediaPlayer media1;
        private MediaPlayer mediaPlayer1;
        public Gold_island()
        {
            InitializeComponent();
            media1 = new MediaPlayer();
            mediaPlayer1 = new MediaPlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\kurenie-vredno-dlya-zdorovya.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\stanovitsya-skuchnovato.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\gde-karta-billi.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\priznayu-sebya-oslom.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\myi-idem-na-poiski-klada.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Stop();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
