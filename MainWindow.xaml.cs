using System;
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
using System.Collections.Generic;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace trypro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool buttonWasClicked = false;
        private Style defaultStyle;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            button1.Click += mouseClick;
            button2.Click += mouseClick;
        }

        private void mouseClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button != null)
                ShapeTool(button.Name);


            
        }


        public void ShapeTool(string shape)
        {

            switch (shape)
            {
                case "button1":
                    button1.Style = (Style)FindResource("BorderButtonColor");
                    button2.Style = defaultStyle;
                    break;

                case "button2":
                    button2.Style = (Style)FindResource("BorderButtonColor");
                    button1.Style = defaultStyle;
                    break;

               
            }


        }

        private void button1_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var button = sender as Button;

            if (button != null)
                ShapeTool(button.Name);

        }
    }
}
