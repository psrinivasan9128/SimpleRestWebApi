using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using SimpleRestWebApi.WebApi.Controllers;
using SimpleRestWebApi.WebApi.Models;
using System.Collections;

namespace SimpleRestWebApi.Tests
{
    public class GeneralControllerTest
    {
        private readonly GeneralController _controller = new GeneralController(); 
        [Fact]
        public void ValidateGetSum()
        {
            int x;
            int y;

            x = 3;
            y = 5;
            var result = _controller.GetSum(x, y);
            Assert.Equal("8", result.Value);

        }
    }
}
