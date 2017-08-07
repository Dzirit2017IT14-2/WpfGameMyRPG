using System;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGameMyRPG
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void ButtonStart_Click(Object sender, EventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.Owner = this;
            if (logInWindow.ShowDialog() == true)
            {
                MessageBox.Show("успешное нажатие");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            BitmapImage bgButton = new BitmapImage();
            try
            {
                //LoadResourse();
                //Фон окна
                String pathBackground = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\Resourse\\Image\\Menu.png";
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
                MessageBox.Show("Произошла ошибка загрузки:\n" + ex.Message, "Ошибка",  MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Button buttonStart = new Button
            {
                Width = 300,
                Height = 40,
                Margin = new Thickness(250.0, 110.0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                FontSize = 14,
                FontWeight = FontWeights.Bold,
                Background = new ImageBrush(bgButton),
                Content = "Начать игру"
            };
            buttonStart.Click += ButtonStart_Click;
            MainMenu.Children.Add(buttonStart);
            Button Loading = new Button
            {
                Width = 300,
                Height = 40,
                Margin = new Thickness(250.0, 160.0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                FontSize = 14,
                FontWeight = FontWeights.Bold,
                Background = new ImageBrush(bgButton),
                Content = "Загрузить сохранённую игру"
            };
            MainMenu.Children.Add(Loading);
            Button Information = new Button
            {
                Width = 300,
                Height = 40,
                Margin = new Thickness(250.0, 210.0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                FontSize = 14,
                FontWeight = FontWeights.Bold,
                Background = new ImageBrush(bgButton),
                Content = "Информация по игре"
            };
            MainMenu.Children.Add(Information);
        }
    }
}
