using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealtimeChartIdea.Models
{
    public class ChartData
    {
        public string[] Labels { get; set; }
        public ChartDataset[] Datasets { get; set; }
    }
}