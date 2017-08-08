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
            LogInWindow logInWindow = new LogInWindow() { Owner = this };
            Visibility = Visibility.Hidden;
            if (logInWindow.ShowDialog() == true)
            {
                Visibility = Visibility.Visible;
                MessageBox.Show("успешное нажатие");
            }
            else Visibility = Visibility.Visible;
        }
        private void ButtonExit_Click(Object sender, EventArgs e)
        {
            TestRandomForm frm = new TestRandomForm();
            frm.Show();
            /*Application app = Application.Current;
            app.Shutdown();*/
        }

        public MainWindow()
        {
            InitializeComponent();
            BitmapImage bgButton = new BitmapImage();
            try
            {
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
            //кнопка старт
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
            //кнопка загрузка игры
            Button buttonLoading = new Button
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
            MainMenu.Children.Add(buttonLoading);
            //кнопка информация по игре
            Button buttonInformation = new Button
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
            MainMenu.Children.Add(buttonInformation);
            //кнопка выход
            Button buttonExit = new Button
            {
                Width = 300,
                Height = 40,
                Margin = new Thickness(250.0, 510.0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                FontSize = 14,
                FontWeight = FontWeights.Bold,
                Background = new ImageBrush(bgButton),
                Content = "Выход"
            };
            buttonExit.Click += ButtonExit_Click;
            MainMenu.Children.Add(buttonExit);
        }
    }
}
