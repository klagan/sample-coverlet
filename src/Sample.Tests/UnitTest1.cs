using NUnit.Framework;

// https://github.com/coverlet-coverage/coverlet
// https://docs.microsoft.com/en-us/learn/modules/run-quality-tests-build-pipeline/6-perform-code-coverage

namespace Sample.Tests
{
    using Library;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var lib = new MyLib();

            var a = lib.Test();
            
            Assert.AreSame("Test", a);
        }
    }
}