using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _13_TopSpotsAPI.Models;
using System.IO;

namespace _13_TopSpotsAPI.Controllers
{
    public class SpotsController : ApiController
    {
        // Get /api/TopSpot
        public IEnumerable<TopSpot> get()
        {
            TopSpot[] TopSpots = JsonConvert.DeserializeObject<TopSpot[]>(File.ReadAllText(@"\\Mac\Home\Documents\dev windows\13-TopSpotsAPI\TopSpots.json"));
            return TopSpots;

        }
    }
}
