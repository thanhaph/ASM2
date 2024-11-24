using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2.Test.Bai2Test
{
    [TestFixture]
    public class AddTest
    {
        private Servece_2 _b2 = new Servece_2();
        [Test]
        [TestCase("ha", "Ma1", "Lo1", "Ma2", ExpectedResult = true)]
        [TestCase("haha", "Ma1", "Ten1", "Ma2", ExpectedResult = true)]
        [TestCase("H", "Ma1", "Ten1", "Ma2", ExpectedResult = true)]
        [TestCase("ha", "Mama", "Ten1", "Ma2", ExpectedResult = true)]
        [TestCase("ha", "M", "TenLop1", "Ma2", ExpectedResult = true)]
        [TestCase("ha", "Ma", "TenLop1", "Ma2", ExpectedResult = true)]
        [TestCase("ha", "MaLop1", "TenLopMot", "Ma2", ExpectedResult = true)]
        [TestCase("ha", "MaLop1", "Te", "Ma2", ExpectedResult = true)]
        [TestCase("ha", "MaLop1", "Te", "MaSinhVien", ExpectedResult = true)]
        // Độ dài vượt quá 10 ký tự:
        [TestCase("hahahahahahha", "MaLop1", "TenLop1", "Ma2", ExpectedResult = typeof(Exception))]
        [TestCase("ha", "MaLopMaLopMaLop", "TenLopgg", "Ma2", ExpectedResult = typeof(Exception))]

        // Trùng mã sinh viên:
        [TestCase("ha", "MALop1", "TenLop1", "Ma1", ExpectedResult = typeof(Exception))]
        [TestCase("ha", "MALop1", "TenLop1", "Ma3", ExpectedResult = typeof(Exception))]

        // Để trống 1 trường hoặc nhập phím cách:
        [TestCase("ha", "MALop1", "     ", "Ma1", ExpectedResult = typeof(Exception))]
        [TestCase("ha", "    ", "TenLop1", "Ma3", ExpectedResult = typeof(Exception))]

        // Tên Lớp chứa ký tự đặc biêt:
        [TestCase("ha", "MA", "$@$", "Ma8", ExpectedResult = typeof(Exception))]

        public bool ThemSv(string hoten, string malop, string tenlop, string masv)
        {
            Sinhvien haha = new Sinhvien("id", "ha", "MaLop1", "TenLop1", "Ma1");
            Sinhvien haha1 = new Sinhvien("id", "ha", "MaLop1", "TenLop1", "Ma3");
            _b2.AddSV(haha);
            _b2.AddSV(haha1);
            Sinhvien svmoi = new Sinhvien("id", hoten, malop, tenlop, masv);
            return _b2.AddSV(svmoi);
        }

    }
}
