using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsByName()
        {
            var returnValue = controller.Get();
            Assert.NotNull(returnValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
