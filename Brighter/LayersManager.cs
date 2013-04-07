using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brighter
{
    class LayersManager
    {
        public static List<Layer> LayersProperty { get; private set; }
        
        public LayersManager()
        {
            LayersProperty = new List<Layer>();
        }

        public static void AddLayer(Layer l)
        {
            LayersProperty.Add(l);
        }

        public static void RemoveLayer(Layer l)
        {
            LayersProperty.Remove(l);
        }
    }
}
