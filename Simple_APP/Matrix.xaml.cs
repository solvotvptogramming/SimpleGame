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
    /// Логика взаимодействия для Matrix.xaml
    /// </summary>
    public partial class Matrix : Page
    {
        private MediaPlayer media1;
        private MediaPlayer mediaPlayer1;
        public Matrix()
        {
            InitializeComponent();
            media1 = new MediaPlayer();
            mediaPlayer1 = new MediaPlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\ochisti-svoy-mozg.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\tyi-mojesh-byistree-predela-net.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\effekt-matritsyi-29966.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\ya-daje-vozduhom-ne-dyishu.wav", UriKind.Absolute));
            mediaPlayer1.Play();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\vse-myi-padali-v-pervyiy-raz.wav", UriKind.Absolute));
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
