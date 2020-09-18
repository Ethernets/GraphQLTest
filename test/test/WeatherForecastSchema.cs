using GraphQL.Types;
using GraphQL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class WeatherForecastSchema : Schema
    {
        public WeatherForecastSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<WeatherForecastQuery>();
           // Mutation = provider.GetRequiredService<StarWarsMutation>();
        }
    }
}
