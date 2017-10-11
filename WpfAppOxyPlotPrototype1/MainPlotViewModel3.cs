using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OxyPlot;
using OxyPlot.Series;
using System.ComponentModel;

namespace WpfAppOxyPlotPrototype1
{
    class MainPlotViewModel3
    {

        public string Title { get; private set; }

        // Once you update this property with MVVM style it 
        // will be reflected in View
        public PlotModel ModelVM { get; set; }

        public MainPlotViewModel3()
        {
            Title = "Nusim Proto1";
            LineSeries ser1 = new LineSeries();
            ser1.Points.Add(new DataPoint(1, 2));
            ser1.Points.Add(new DataPoint(2, 3));
            ser1.Points.Add(new DataPoint(3, 4));
            ser1.Points.Add(new DataPoint(4, 7));
            ser1.Points.Add(new DataPoint(5, 9));
            ser1.Points.Add(new DataPoint(6, 10));
            ser1.Points.Add(new DataPoint(7, 13));
            ser1.Points.Add(new DataPoint(8, 10));
            ser1.Points.Add(new DataPoint(9, 7));

            LineSeries ser2 = new LineSeries();
            ser2.Points.Add(new DataPoint(1, 5));
            ser2.Points.Add(new DataPoint(2, 6));
            ser2.Points.Add(new DataPoint(3, 7));
            ser2.Points.Add(new DataPoint(4, 9));
            ser2.Points.Add(new DataPoint(5, 1));
            ser2.Points.Add(new DataPoint(6, 0));
            ser2.Points.Add(new DataPoint(7, 3));
            ser2.Points.Add(new DataPoint(8, 4));
            ser2.Points.Add(new DataPoint(9, 7));

            LineSeries ser3 = new LineSeries();
            ser3.Points.Add(new DataPoint(8, 4));
            ser3.Points.Add(new DataPoint(9, 7));

            ModelVM = new PlotModel();
            ModelVM.Series.Add(ser1);
            ModelVM.Series.Add(ser2);
            ModelVM.Series.Add(ser3);
        }
    }
}
