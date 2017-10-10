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
    class MainPlotViewModel1
    {
        public MainPlotViewModel1()
        {
            this.MyModel = new PlotModel { Title = "Example 1" };
            this.MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
        }

        public PlotModel MyModel { get; private set; }
    }
}
