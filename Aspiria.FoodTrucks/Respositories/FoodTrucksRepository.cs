using Aspiria.FoodTrucks.Filters;
using Aspiria.FoodTrucks.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Aspiria.FoodTrucks.Respositories
{
    public class FoodTrucksRepository<T> where T : class
    {
        private readonly ApiConfig apiConfig;
        public FoodTrucksRepository(IConfiguration _config)
        {
            var config = _config.GetSection("ApiConfig");
            apiConfig = new ApiConfig();
            config.Bind(apiConfig);
        }

        public ICollection<FoodTruck> fetch(DateTimeFilter filter = null)
        {
            var query = new SODA.SoqlQuery().Select("distinct Applicant", "locationdesc", "dayorder").Order("Applicant");
            if(filter != null)
            {
                query = query
                    .Where($" ('{filter.Time.ToString(@"hh\:mm")}' between Start24 and End24 ) and dayorder = '{filter.Day}'");
            }
            var client = new SODA.SodaClient(apiConfig.Url, apiConfig.AppToken);
            var data = client.GetResource<Models.FoodTruck>("jjew-r69b");

            var result = data.Query<Models.FoodTruck>(query);

            return result.ToList();
        }
    }
}
