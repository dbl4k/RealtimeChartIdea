using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealtimeChartIdea.Models;
using RealtimeChartIdea.DataProviders;
using RealtimeChartIdea.Factories;

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
        public ChartData Details(String id)
        {
            ChartData data = null;
            //ChartData data = MockDataProvider.getRandomData(new Random());

            Dictionary <string, int[]> source = new Dictionary<string, int[]>();

            source["Banana"] = new int[]{ 1, 3, 2, 5};
            source["Apple"] = new int[] { 4, 2, 5, 1 };
            source["Orange"] = new int[] { 8, 6, 10, 4 };

            data = ChartDataFactory.CreateLineData(source);

            return data;
        }


       
       
    }
}