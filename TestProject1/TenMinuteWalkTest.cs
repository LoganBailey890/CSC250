using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeWars;

namespace TestProject1
{
    class TenMinuteWalkTest
    {
        /*[Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, TenMinuteWalk.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
            Assert.AreEqual(false, TenMinuteWalk.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
            Assert.AreEqual(false, TenMinuteWalk.IsValidWalk(new string[] { "w" }), "should return false");
            Assert.AreEqual(false, TenMinuteWalk.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }*/
        /*[Test]
        public void BasicTests()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var expected = new int[] { 6, 6, 3 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", FoldAnArray.FoldArray(input, 1)));

            expected = new int[] { 9, 6 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", FoldAnArray.FoldArray(input, 2)));

            expected = new int[] { 15 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", FoldAnArray.FoldArray(input, 3)));

            input = new int[] { -9, 9, -8, 8, 66, 23 };
            expected = new int[] { 14, 75, 0 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", FoldAnArray.FoldArray(input, 1)));
        }*/

        [Test]
        public static void ExampleTests()
        {
            Assert.AreEqual(29, BagPack.PackBagpack(new int[] { 15, 10, 9, 5 }, new int[] { 1, 5, 3, 4 }, 8));
            Assert.AreEqual(60, BagPack.PackBagpack(new int[] { 20, 5, 10, 40, 15, 25 }, new int[] { 1, 2, 3, 8, 7, 4 }, 10));
        }

        /*[Test]
        public void Test1()
        {
            int rectangles = BagPack.NumberOfRectangles(4, 4);
            Assert.AreEqual(100, rectangles);
        }

        [Test]
        public void Test2()
        {
            int rectangles = BagPack.NumberOfRectangles(5, 5);
            Assert.AreEqual(225, rectangles);
        }*/

        [Test]
        public void Test1()
        {

            Assert.AreEqual(1602, BagPack.PackBagpack(
                new int[] {5,51,81,32,19,2,89,19,7,63,17,69,10,15,55,27,53,62,86,45,46,63,61,93,49,8,90,47,52,35,90,19,34,1,38,99,19,31,66,92,41,16,10,28,38,9,25,71,90,3,70,61,2,93,28,41,90,88,82,12,11,42,66,71,73,98,35,10,77,55,8,23,95,93,4,30,54,34,55,40,82,20,57,50,65,29,18,41,72,96,10,30,48,54,81,98,50,38,54,40,73,16,94,36,94,48},
                new int[] { 6,10,29,24,20,20,7,12,24,11,16,26,24,13,25,1,15,29,29,10,15,24,28,24,13,1,17,21,23,2,2,19,20,28,8,28,7,6,7,19,7,28,10,7,11,9,23,12,2,26,9,14,28,18,6,12,11,5,11,19,3,16,19,22,10,27,6,26,5,27,23,10,22,11,4,16,14,22,14,4,8,6,20,27,23,17,20,3,22,26,17,2,24,17,17,21,10,18,26,13,4,26,7,4,3,29 },
                142));


        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(89, BagPack.PackBagpack(new int[] { 15, 13, 15, 16, 5, 18, 7 }, new int[] { 1, 1, 1, 3, 2, 2, 3 }, 98));


        }
    }
}
