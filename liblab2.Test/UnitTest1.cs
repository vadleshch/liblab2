namespace liblab2.Test
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
        [Test]
        public void ollehTest()
        {
            var reverse = new Reverse();
            string res = reverse.rev("hello");
            Assert.That(res, Is.EqualTo("olleh"));
        }

        [Test]
        public void _Test()
        {
            var reverse = new Reverse();
            string res = reverse.rev("");
            Assert.That(res, Is.EqualTo(""));
        }

        [Test]
        public void oneTest()
        {
            var reverse = new Reverse();
            string res = reverse.rev("a");
            Assert.That(res, Is.EqualTo("a"));
        }
    }
}
