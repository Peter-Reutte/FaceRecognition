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
using System.Windows.Shapes;

namespace FaceRecognition
{
    /// <summary>
    /// Логика взаимодействия для CheckPhoto.xaml
    /// </summary>
    public partial class CheckPhoto : Window
    {
        public CheckPhoto(Image bitmapFrame)
        {
            InitializeComponent();
            ImageWebcamFrame.Source = bitmapFrame.Source;
        }

        private void ButtonPhoto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
