using System;
using Zoo.Classes;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void getOlderTest()
        {
            Animal lion = new Animal("Mhsn", "Mammals", 10, "Meat", true, false, 5);
            lion.getOlder();
            Assert.Equal(11,lion.age);

        }
        [Fact]
        public void deadTest()
        {
            Animal blueTang = new Animal("Hala", "Fish", 2, "Kelp", false, true, 20);
            string name = blueTang.Name;
            blueTang.dead();
            Assert.Equal(0, blueTang.age);
            Assert.Equal(name+" (dead)", blueTang.Name);

        }
    }
}
