using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class WeatherForecastType : ObjectGraphType<WeatherForecast>
    {
        public WeatherForecastType()
        {
            Name = "Test";
            Field(_ => _.Id);
            Field(_ => _.Summary);
            Field(_ => _.TemperatureC);
            Field(_ => _.TemperatureF);
            Field(_ => _.Date);
        }
    }
}
