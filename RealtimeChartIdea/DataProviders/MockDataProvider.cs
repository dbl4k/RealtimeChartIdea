using RealtimeChartIdea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealtimeChartIdea.DataProviders
{
    public static class MockDataProvider
    {
        public static ChartDataSet getRandomDataset(Random r)
        {
            ChartDataSet dataSet = new ChartDataSet();

            dataSet.Labels = new string[]
                              {"Apples",
                              "Oranges",
                              "Pears",
                              "Pineapples",
                              "Bananas"};

            dataSet.Values = getRandoms(r, dataSet.Labels.Length, 0, 10);

            return dataSet;
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
