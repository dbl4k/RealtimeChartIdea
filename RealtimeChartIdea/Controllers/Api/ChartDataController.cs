using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RealtimeChartIdea.Controllers.Api
{
    [Route("api/[controller]")]
    public class ChartDataController : Controller
    {
        // GET: ChartData
        [HttpGet]
        public String Index()
        {
            return "Must provide a ChartId";
        }

        // GET: ChartData/Details/5
        [HttpGet("{id}")]
        public ChartDataSet Details(String id)
        {
            ChartDataSet dataSet = new ChartDataSet();

            dataSet.Labels = new string[]
                              {"Apples",
                              "Oranges",
                              "Pears",
                              "Pineapples",
                              "Bananas"};

            dataSet.Values = getRandoms(dataSet.Labels.Length, 0, 10);
            
            return dataSet;
        }


        private int[] getRandoms(int count, int min, int max)
        {
            List<int> result = new List<int>();
            Random r = new Random();

            for (int i = 0; i < count; i++)
            {
                result.Add(r.Next(min, max));   
            }

            return result.ToArray();
        }

        // TODO extract to Models namespace...
        public class ChartDataSet
        {
            public string[] Labels { get; set; }
            public int[] Values { get; set; }
        }
        
    }
}