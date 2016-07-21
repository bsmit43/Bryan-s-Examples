using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class ViewModel
    {
        //uses the Log Base class to convert collection data into points that the graphs can use
        public ObservableCollection<Model> Collection { get; set; }
        public ViewModel()
        {
            Collection = new ObservableCollection<Model>();
            GenerateDatas();
        }
        private void GenerateDatas()
        {
            this.Collection.Add(new Model(0, 1));
            this.Collection.Add(new Model(1, 2));
            this.Collection.Add(new Model(2, 3));
            this.Collection.Add(new Model(3, 1));
        }
    }
}