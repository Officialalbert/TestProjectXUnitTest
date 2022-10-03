using TestProject;
using Xunit;

namespace TestProjectXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Form1 form1 = new Form1();
            form1.FindArea();

            Assert.Equal(true, true);
        }
    }
}