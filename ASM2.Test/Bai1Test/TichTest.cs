using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2.Test.Bai1Test
{
    [TestFixture]
    public class TichTest
    {
        private Servece_1 _b1 = new Servece_1();
        [Test]
        
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(10, 10, ExpectedResult = 100)]
        [TestCase(9, 9, ExpectedResult = 81)]
        [TestCase(1, 10, ExpectedResult = 10)]
        [TestCase(10, 1, ExpectedResult = 10)]
        [TestCase(9, 10, ExpectedResult = 90)]
        [TestCase(8, 10, ExpectedResult = 80)]
        [TestCase(8, 9, ExpectedResult = 72)]
        [TestCase(8, 1, ExpectedResult = 8)]
        [TestCase(-1, 1, ExpectedResult = typeof(Exception))]
        [TestCase(8, 11, ExpectedResult = typeof(Exception))]
        [TestCase(3, 3, ExpectedResult = 9)]
        [TestCase(4, 4, ExpectedResult = 16)]
        [TestCase(5, 5, ExpectedResult = 25)]
        [TestCase(6, 6, ExpectedResult = 36)]
        [TestCase(7, 7, ExpectedResult = 49)]
        [TestCase(3, 7, ExpectedResult = 21)]
        [TestCase(4, 6, ExpectedResult = 24)]
        [TestCase(5, 5, ExpectedResult = 25)]
        [TestCase(6, 4, ExpectedResult = 24)]
        [TestCase(7, 3, ExpectedResult = 21)]
        [TestCase(9, "3", ExpectedResult = typeof(Exception))]
        [TestCase(null, 2, ExpectedResult = typeof(Exception))]
        public int TinhTich(object a, object b)
        {
            return _b1.tich(a, b);
        }
    }
}
