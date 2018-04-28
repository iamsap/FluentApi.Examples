using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;

namespace FluentApi.ExistingApis.FluentAssertions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            // Act
            Action action = () => new TestMe().TestThis(null);

            // Assert
            action.Should().Throw<ArgumentNullException>()
                  .And
                  .ParamName
                  .Should()
                  .Be("requiredParam");
        }
    }
}
