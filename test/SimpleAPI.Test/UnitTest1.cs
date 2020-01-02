using System;
using Xunit;
using SimpleAPI.Controllers;

using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    //https://www.youtube.com/watch?v=SOtC1VLZKm4&list=PLpSmZmoBaROZm0ucoQchgBJJ_SyTZWbC0&index=4&t=0s
    //Use above link from 10:00 to 25:00 to see how unit test attach to actual project
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsbyId()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Something else", returnValue.Value);
        }
    }
}
