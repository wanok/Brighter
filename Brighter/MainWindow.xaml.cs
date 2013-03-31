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
        private MenuBar Menu;
        private Tools toolPanel;
        CustomCanvas canvas;
        private ColorInfoPanel colorPanel;
        internal static ToolsTypes CurrentTool { get; set; }
        private LayersPanel layersPanel;

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
            colorPanel = new ColorInfoPanel();
            Grid.SetColumn(colorPanel, 1);
            Grid.SetRow(colorPanel, 2);
            MainGrid.Children.Add(colorPanel);
            layersPanel = new LayersPanel();
            Grid.SetColumn(layersPanel, 1);
            Grid.SetRow(layersPanel, 3);
            MainGrid.Children.Add(layersPanel);
        }
    }
}
