using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media;

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
        private ColorInfoPanel colorPanel;
        internal static ToolsTypes CurrentTool { get; set; }
        private LayersPanel layersPanel;
        private static LayersManager lManager;
        private static System.Windows.Controls.Canvas CanvasHolder;

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
            lManager = new LayersManager();
            CanvasHolder = new Canvas();
            CanvasHolder.Background = new SolidColorBrush(Colors.Gray);
            Viewport.Content = CanvasHolder;
        }

        public static void Refresh()
        {
            CanvasHolder.Children.Clear();
            var lE = LayersManager.LayersProperty.GetEnumerator();
            while (lE.MoveNext())
            {
                Canvas.SetZIndex(lE.Current, lE.Current.zIndex);
                CanvasHolder.Children.Add(lE.Current);
            }
        }
    }
}
