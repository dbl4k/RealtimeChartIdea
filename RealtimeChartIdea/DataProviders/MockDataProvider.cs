using RealtimeChartIdea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealtimeChartIdea.DataProviders
{
    public static class MockDataProvider
    {
        public static ChartData getRandomData(Random r)
        {
            ChartData data = new ChartData();

            data.Labels = new string[]
                              {"Apples",
                              "Oranges",
                              "Pears",
                              "Pineapples",
                              "Bananas"};


            data.Datasets = new ChartDataset[] { };
            int[] randoms = getRandoms(r, data.Labels.Length, 0, 10);

            data.Datasets[0].Data = randoms;
            
            return data;
        }

        private static int[] getRandoms(Random r, int count, int min, int max)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < count; i++)
            {
                result.Add(r.Next(min, max));
            }

            return result.ToArray();
        }
    }   
}
