using System;
using System.Windows;
using System.Windows.Forms;

namespace Brighter
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : System.Windows.Controls.UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        void File_Open_Click(Object sender, RoutedEventArgs eventArgs)
        {
            var openFile = new OpenFileDialog
                {
                    Filter = "Image Files (*.PNG; *.JPG; *.JPEG; *.GIF) | *.PNG; *.JPG; *.JPEG; *.GIF",
                    FilterIndex = 2
                };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                LayersManager.AddLayer(new Layer(openFile.FileName, 0));
                MainWindow.Refresh();
            }
        }

        private void CheckExistsFile()
        {
            
        }
    }
}
