using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealtimeChartIdea.Models;
using RealtimeChartIdea.DataProviders;

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
            ChartDataSet dataSet = MockDataProvider.getRandomDataset(new Random());
                        
            return dataSet;
        }


       
       
    }
}