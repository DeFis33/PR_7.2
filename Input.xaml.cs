using System;
using System.Windows;

namespace PR7._2
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        public double CubeEdge { get; private set; }
        public double CircleRadius { get; private set; }
        public bool SquareChecked { get; private set; }
        public bool AllSquareChecked { get; private set; }
        public bool DiagonalChecked { get; private set; }
        public Input()
        {
            InitializeComponent();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(CubeEdgeTextBox.Text, out double cubeEdge) && double.TryParse(CircleRadiusTextBox.Text, out double circleRadius))
            {
                if (cubeEdge < 0 || circleRadius < 0)
                {
                    MessageBox.Show("Cube edge or circle radius must be non-negative values.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    CubeEdgeTextBox.Clear();
                    CircleRadiusTextBox.Clear();
                    return;
                }
                CubeEdge = cubeEdge;
                CircleRadius = circleRadius;
                SquareChecked = SquareCheckBox.IsChecked ?? false;
                AllSquareChecked = AllSquareCheckBox.IsChecked ?? false;
                DiagonalChecked = DiagonalCheckBox.IsChecked ?? false;

                PerformCalculations();
            }
            else
            {
                MessageBox.Show("Please enter valid numerical values for cube edge and circle radius.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                CubeEdgeTextBox.Clear();
                CircleRadiusTextBox.Clear();
            }
        }
        private void PerformCalculations()
        {
            bool anyOptionSelected = false;

            if (SquareChecked)
            {
                anyOptionSelected = true;
                double square = Math.Pow(CubeEdge, 2);
                MessageBox.Show($"Cube face area: {square}");
            }
            if (AllSquareChecked)
            {
                anyOptionSelected = true;
                double allSquare = 6 * Math.Pow(CubeEdge, 2);
                MessageBox.Show($"Cube surface area: {allSquare}");
            }
            if (DiagonalChecked)
            {
                anyOptionSelected = true;
                double diagonal = Math.Sqrt(3) * CubeEdge;
                MessageBox.Show($"Cube diagonal: {diagonal}");
            }
            if (!anyOptionSelected)
            {
                MessageBox.Show("No option selected. Please select at least one option to calculate.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                CubeEdgeTextBox.Clear();
                CircleRadiusTextBox.Clear();
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}