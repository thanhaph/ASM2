using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2.Test.Bai2Test
{
    [TestFixture]
    public class TimkiemTest
    {
        private Servece_2 _b2 = new Servece_2();
        [Test]
        // YC: Ký tự độ dài không được vượt quá 10 ký tự, tối thiểu 1 ký tự
        [TestCase("Ma2", ExpectedResult = true)]
        [TestCase("Ma3", ExpectedResult = true)]
        [TestCase("Ma4", ExpectedResult = true)]
        [TestCase("Ma9", ExpectedResult = true)]
        [TestCase("MaPH", ExpectedResult = true)]


        // Trường hợp ko tìm thấy 
        [TestCase("MaPeeH", ExpectedResult = false)]
        [TestCase("MaPee23H", ExpectedResult = false)]
        [TestCase("MaPee4H", ExpectedResult = false)]
        [TestCase("MeH", ExpectedResult = false)]
        public bool TimTheoMSV(string masv)
        {
            if (masv.Length > 10)
            {
                throw new Exception("Quá độ dài cho phép");
            }

            _b2.svien = new List<Sinhvien>()
            {
                new Sinhvien("id", "haha", "MaLop1", "TenLop1", "MaPH"),
                new Sinhvien("id", "haha", "MaLop1", "TenLop1", "Ma2"),
                new Sinhvien("id", "haha", "MaLop1", "TenLop1", "Ma3"),
                new Sinhvien("id", "haha", "MaLop1", "TenLop1", "Ma4"),
                new Sinhvien("id", "haha", "MaLop1", "TenLop1", "Ma9"),
                new Sinhvien("id", "haha", "MaLop1", "TenLop1", "Ma10"),
            };


            return _b2.svien.Any(x => x.masv == masv);
        }
    }
}
