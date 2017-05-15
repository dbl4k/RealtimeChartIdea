using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealtimeChartIdea.Models;

namespace RealtimeChartIdea.Factories
{
    public class ChartDataFactory
    {
        public static ChartData CreateLineData(Dictionary<String, int[]> values)
        {
            ChartData data = new ChartData();
            data.Labels = new string[] { };
            data.Datasets = new ChartDataset[] { };

            foreach (KeyValuePair<String, int[]> item in values)
            {
                // TODO: thee are corresponding XAxes labels rather than series labels.
                string[] labels = data.Labels;
                Array.Resize(ref labels, labels.Length + 1);
                labels[labels.Length - 1] = item.Key.ToString();
                data.Labels = labels;

                // add a dataset
                ChartDataset[] datasets = data.Datasets;
                Array.Resize(ref datasets, datasets.Length + 1);
                datasets[datasets.Length - 1] = new ChartDataset();
                datasets[datasets.Length - 1].Label = item.Key.ToString();
                datasets[datasets.Length - 1].Data = item.Value;
                data.Datasets = datasets;

            }
            
            return data;
        }

    }
}
