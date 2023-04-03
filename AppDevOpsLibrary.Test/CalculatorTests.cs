using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppDevOpsLibrary.Test
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 2, 2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Arrange

            //Act
            double actual = Calculator.Divide(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
