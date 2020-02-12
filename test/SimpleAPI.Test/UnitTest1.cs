using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    using System.Linq;

    public class UnitTest1
    {
        readonly WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName()
        {
            var forecasts = this.controller.Get();
            var lastForecast = forecasts.Last();
            Assert.Equal("It makes no difference who we are!", lastForecast.Summary);
            Assert.Equal(-20, lastForecast.TemperatureC);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
