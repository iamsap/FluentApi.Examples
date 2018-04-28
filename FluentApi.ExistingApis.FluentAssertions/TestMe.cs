using System;
namespace FluentApi.ExistingApis.FluentAssertions
{
    public class TestMe
    {
        public TestMe()
        {
        }

        public void TestThis(string requiredParam)
        {
            throw new ArgumentNullException(nameof(requiredParam));
        }
    }
}
