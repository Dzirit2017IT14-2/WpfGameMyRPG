using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfGameMyRPG
{
    /// <summary>
    /// Логика взаимодействия для LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
            BitmapImage bgButton = new BitmapImage();
            try
            {
                //Фон окна
                String pathBackground = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\Resourse\\Image\\Login.png";
                Background = new ImageBrush(new BitmapImage(new Uri(pathBackground, UriKind.Absolute)));
                //Фон кнопки
                pathBackground = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\Resourse\\Image\\Button1.png";
                bgButton = new BitmapImage(new Uri(pathBackground, UriKind.Absolute));
                //Иконка
                pathBackground = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\Resourse\\Image\\Icon.ico";
                this.Icon = BitmapFrame.Create(new Uri(pathBackground, UriKind.Absolute));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка загрузки:\n" + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
