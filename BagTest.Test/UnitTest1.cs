using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mime;

namespace BagTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Bag_Should_Add_Content()
        {
            var contentOne = new Content(3, 4, 5);
            var bag = new Bag(9,9,11);

            bag.VolumeAmount(9, 9, 11);
            var add = bag.Add(contentOne);

            Assert.IsTrue(add);
        }

        [TestMethod]
        public void Bag_Volume_Correct()
        {
            var bag = new Bag(9,9,9);
            bag.VolumeAmount(5,5,5);
            Assert.AreEqual(15, bag.VolumeAmount(5,5,5));
        }

    }
}
