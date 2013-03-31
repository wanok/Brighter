using System.Windows;
using System.Windows.Controls;

namespace Brighter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        MenuBar Menu;
        Tools toolPanel;
        CustomCanvas canvas;

        public MainWindow()
        {
            InitializeComponent();
            InitializeOtherComponents();
        }

        private void InitializeOtherComponents()
        {
            Menu = new MenuBar();
            Grid.SetColumn(Menu, 0);
            Grid.SetRow(Menu, 0);
            Grid.SetColumnSpan(Menu, 2);
            MainGrid.Children.Add(Menu);
            toolPanel = new Tools();
            Grid.SetColumn(toolPanel, 1);
            Grid.SetRow(toolPanel, 1);
            MainGrid.Children.Add(toolPanel);
        }
    }
}
