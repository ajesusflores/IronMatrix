using System;
using Xunit;
using IronMatrix;

namespace IronMatrix.Tests
{
    public class InitialTest
    {
        private readonly Vector algebraService;

        public InitialTest()
        {
            algebraService = new Vector();
        }


        [Fact]
        public void MustRunAndReturnValue()
        {
            var result = algebraService.InitialMethodToTestUTProject(false);

            Assert.False(result, "Value must be false");

        }
    }
}
