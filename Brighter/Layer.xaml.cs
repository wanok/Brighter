using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Brighter
{
    /// <summary>
    /// Interaction logic for Layer.xaml
    /// </summary>
    public partial class Layer : UserControl
    {
        private Image img { get; set; }
        public int zIndex { get; private set; }

        public Layer()
        {
            InitializeComponent();
        }

        public Layer(string filePath, int zIndex)
        {
            InitializeComponent();
            img = new Image();
            var bmp = new BitmapImage(new Uri(filePath));
            img.Source = bmp;
            this.Width = bmp.Width;
            this.Height = bmp.Height;
            Content.Children.Add(img);
            this.zIndex = zIndex;
        }

        public void ChangeZindex(int z)
        {
            zIndex = z;
        }
    }
}
