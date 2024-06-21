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

namespace lab3draw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InkPresenter _inkCanvas;
        private List<Color> _colors;
        private Color _selectedColor;
        private double _brushSize;
        private DrawingMode _mode;
        private bool _isDrawing;
        private Point _startPoint;
        private List<UIElement> _selectedElements = new List<UIElement>();

        public MainWindow()
        {
            InitializeComponent();
            _colors = new List<Color> { Colors.Black, Colors.Red, Colors.Green, Colors.Blue, Colors.Yellow };
            ColorComboBox.ItemsSource = _colors;
            _selectedColor = Colors.Black;

            SizeSlider.ValueChanged += SizeSlider_ValueChanged;

            DrawRadioButton.Checked += ModeRadioButton_Checked;
            EditRadioButton.Checked += ModeRadioButton_Checked;
            EraseRadioButton.Checked += ModeRadioButton_Checked;

            Canvas.MouseDown += Canvas_MouseDown;
            Canvas.MouseMove += Canvas_MouseMove;
            Canvas.MouseUp += Canvas_MouseUp;

            _colors = new List<Color> { Colors.Black, Colors.Red, Colors.Green, Colors.Blue, Colors.Yellow, Colors.HotPink };
            ColorComboBox.ItemsSource = _colors;

            _selectedColor = Colors.Black;
        }

        private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _brushSize = e.NewValue;
        }

        private void ModeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Content.ToString())
            {
                case "Рисование":
                    _mode = DrawingMode.Draw;
                    break;

                case "Редактирование":
                    _mode = DrawingMode.Edit;
                    break;

                case "Удаление":
                    _mode = DrawingMode.Erase;
                    break;
            }
        }
        public enum DrawingMode
        {
            Draw,
            Edit,
            Erase
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_mode == DrawingMode.Draw)
            {
                // Проверяем, существует ли _inkCanvas
                if (_inkCanvas == null)
                {
                    // Если нет, создаем новый экземпляр
                    _inkCanvas = new InkPresenter();
                    Canvas.Children.Add(_inkCanvas);
                }

                if (_mode == DrawingMode.Draw)
                {
                    _isDrawing = true;
                    _startPoint = e.GetPosition(Canvas);
                    Line newLine = new Line
                    {
                        X1 = _startPoint.X,
                        Y1 = _startPoint.Y,
                        X2 = _startPoint.X + 1,
                        Y2 = _startPoint.Y + 1,
                        Stroke = new SolidColorBrush(_selectedColor),
                        StrokeThickness = _brushSize
                    };
                    Canvas.Children.Add(newLine);
                }
                else if (_mode == DrawingMode.Edit)
                {
                    HitTestResult hitResult = VisualTreeHelper.HitTest(Canvas, e.GetPosition(Canvas));
                    if (hitResult != null && hitResult.VisualHit is UIElement)
                    {
                        UIElement selectedElement = (UIElement)hitResult.VisualHit;
                        if (Canvas.Children.Contains(selectedElement))
                        {
                            _selectedElements.Add(selectedElement);
                        }
                    }
                }
                else if (_mode == DrawingMode.Erase)
                {
                    HitTestResult hitResult = VisualTreeHelper.HitTest(Canvas, e.GetPosition(Canvas));
                    if (hitResult != null && hitResult.VisualHit is UIElement)
                    {
                        UIElement selectedElement = (UIElement)hitResult.VisualHit;
                        if (Canvas.Children.Contains(selectedElement))
                        {
                            Canvas.Children.Remove(selectedElement);
                        }
                    }
                }
                

            }

            }
            private void Canvas_MouseMove(object sender, MouseEventArgs e)
            {
                if (_isDrawing && _mode == DrawingMode.Draw)
                {
                    Point currentPosition = e.GetPosition(Canvas);
                    Line newLine = (Line)Canvas.Children[Canvas.Children.Count - 1];
                    newLine.X2 = currentPosition.X;
                    newLine.Y2 = currentPosition.Y;
                }
            }

            private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
            {
                _isDrawing = false;
            }

            private void DrawRadioButton_Checked(object sender, RoutedEventArgs e)
            {

            }

            private void EditRadioButton_Checked(object sender, RoutedEventArgs e)
            {

            }

            private void EraseRadioButton_Checked(object sender, RoutedEventArgs e)
            {

            }

            private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }
        }
    }

