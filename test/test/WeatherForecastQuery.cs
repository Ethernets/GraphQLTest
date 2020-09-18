using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class WeatherForecastQuery : ObjectGraphType
    {
        public WeatherForecastQuery()
        {
            Field<WeatherForecastType>(
                name: "test", resolve: context => new WeatherForecast { Id = 1, Date = DateTime.Now, Summary = "LOL", TemperatureC = 125 });
        }
   }
}
