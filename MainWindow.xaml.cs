using System;
using System.Windows;

namespace PR7._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Input_Click(object sender, RoutedEventArgs e)
        {
            Input inputWindow = new Input();
            inputWindow.Show();
        }
        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            // какие то вычисления
        }
        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            // какой рисунок
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close_Click(sender, e);
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}