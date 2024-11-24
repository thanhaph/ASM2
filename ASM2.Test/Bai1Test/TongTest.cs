using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2.Test.Bai1Test
{
    [TestFixture]
    public class TongTest
    {
        private Servece_1 _b1 = new Servece_1();
        [Test]
        // a: 0 - 10
        // b: 0 - 10
        // Kỹ thuật biên (12 testcase)
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(10, 10, ExpectedResult = 20)]
        [TestCase(9, 9, ExpectedResult = 18)]
        [TestCase(1, 10, ExpectedResult = 11)]
        [TestCase(10, 1, ExpectedResult = 11)]
        [TestCase(9, 10, ExpectedResult = 19)]
        [TestCase(8, 10, ExpectedResult = 18)]
        [TestCase(8, 9, ExpectedResult = 17)]
        [TestCase(8, 1, ExpectedResult = 9)]
        [TestCase(-1, 1, ExpectedResult = typeof(AggregateException))]
        [TestCase(8, 11, ExpectedResult = typeof(AggregateException))]

        // Kỹ thuật phân vùng tương đương (12 testcase)
        [TestCase(3, 3, ExpectedResult = 6)]
        [TestCase(4, 4, ExpectedResult = 8)]
        [TestCase(5, 5, ExpectedResult = 10)]
        [TestCase(6, 6, ExpectedResult = 12)]
        [TestCase(7, 7, ExpectedResult = 14)]
        [TestCase(3, 7, ExpectedResult = 10)]
        [TestCase(4, 6, ExpectedResult = 10)]
        [TestCase(5, 5, ExpectedResult = 10)]
        [TestCase(6, 4, ExpectedResult = 10)]
        [TestCase(7, 3, ExpectedResult = 10)]
        [TestCase(9, "3d", ExpectedResult = typeof(Exception))]
        [TestCase("", 2, ExpectedResult = typeof(Exception))]
        public int TinhTong(object a, object b) => _b1.tong(a, b);
    }
}
