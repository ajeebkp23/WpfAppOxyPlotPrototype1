using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OxyPlot;
using OxyPlot.Series;

namespace WpfAppOxyPlotPrototype1
{
    class MainPlotViewModel2
    {

        public string Title { get; private set; }

        public IList<DataPoint> Points { get; private set; }
        public IList<DataPoint> Points2 { get; private set; }

        public MainPlotViewModel2()
        {
            Title = "Nusim Proto1";
            Points = new List<DataPoint>();
            Points.Add(new DataPoint(1, 2));
            Points.Add(new DataPoint(2, 3));
            Points.Add(new DataPoint(3, 4));
            Points.Add(new DataPoint(4, 7));
            Points.Add(new DataPoint(5, 9));
            Points.Add(new DataPoint(6, 10));
            Points.Add(new DataPoint(7, 13));
            Points.Add(new DataPoint(8, 10));
            Points.Add(new DataPoint(9, 7));

            Points2 = new List<DataPoint>();
            Points2.Add(new DataPoint(1, 5));
            Points2.Add(new DataPoint(2, 6));
            Points2.Add(new DataPoint(3, 7));
            Points2.Add(new DataPoint(4, 9));
            Points2.Add(new DataPoint(5, 1));
            Points2.Add(new DataPoint(6, 0));
            Points2.Add(new DataPoint(7, 3));
            Points2.Add(new DataPoint(8, 4));
            Points2.Add(new DataPoint(9, 7));
        }
    }
}
