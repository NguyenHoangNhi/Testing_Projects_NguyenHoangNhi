using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BTL_86_Nhi_N2;
using System.Text;

namespace GiaiPT2_Tester_86_Nhi
{
    [TestClass]
    public class TestPT_86_Nhi
    {
        private PhuongTrinh_86_Nhi pt_86_Nhi;
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestVoNghiem_86_Nhi()
        {
            //Khai báo 2 biến kiểu string
            string expected_86_Nhi, actual_86_Nhi;
            //Khởi tạo một đối tưởng mới của lớp PhuongTrinh_86_Nhi và gán vào biến pt_86_Nhi
            pt_86_Nhi = new PhuongTrinh_86_Nhi(2, 3, 4);
            //Gán kết quả mong đợi vào biến expected_86_Nhi
            expected_86_Nhi = "Phương trình vô nghiệm";
            //Gọi phương thức GiaiPT_86_Nhi để giải phương trình sau khi đã truyền tham số và gán vào biến actual_86_Nhi
            actual_86_Nhi = pt_86_Nhi.GiaiPT_86_Nhi();
            //So sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_86_Nhi, actual_86_Nhi);
        }
        [TestMethod]
        public void TestNghiemKep_86_Nhi()
        {
            //Khai báo 2 biến kiểu string
            string expected_86_Nhi, actual_86_Nhi;
            //Khởi tạo một đối tưởng mới của lớp PhuongTrinh_86_Nhi và gán vào biến pt_86_Nhi
            pt_86_Nhi = new PhuongTrinh_86_Nhi(1, 2, 1);
            //Gán kết quả mong đợi vào biến expected_86_Nhi
            expected_86_Nhi = "Phương trình có nghiệm kép là:\r\nx1 = x2 = -1";
            //Gọi phương thức GiaiPT_86_Nhi để giải phương trình sau khi đã truyền tham số và gán vào biến actual_86_Nhi
            actual_86_Nhi = pt_86_Nhi.GiaiPT_86_Nhi();
            //So sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_86_Nhi, actual_86_Nhi);
        }
        [TestMethod]
        public void TestCoNghiem_86_Nhi()
        {
            //Khai báo 2 biến kiểu string
            string expected_86_Nhi, actual_86_Nhi;
            //Khởi tạo một đối tưởng mới của lớp PhuongTrinh_86_Nhi và gán vào biến pt_86_Nhi
            pt_86_Nhi = new PhuongTrinh_86_Nhi(1, -5, 6);
            //Gán kết quả mong đợi vào biến expected_86_Nhi
            expected_86_Nhi = "Phương trình có 2 nghiệm phân biệt:\r\nx1 = 3\r\nx2 = 2";
            //Gọi phương thức GiaiPT_86_Nhi để giải phương trình sau khi đã truyền tham số và gán vào biến actual_86_Nhi
            actual_86_Nhi = pt_86_Nhi.GiaiPT_86_Nhi();
            //So sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_86_Nhi, actual_86_Nhi);
        }
        //Nghiệm thuộc phương trình
        [TestMethod]
        public void TestNghiemThuoc_86_Nhi()
        {
            //Khai báo 2 biến kiểu string
            string expected_86_Nhi, actual_86_Nhi;
            //Khởi tạo một đối tưởng mới của lớp PhuongTrinh_86_Nhi và gán vào biến pt_86_Nhi
            pt_86_Nhi = new PhuongTrinh_86_Nhi(1, -5, 6);
            //Gán kết quả mong đợi vào biến expected_86_Nhi
            expected_86_Nhi = 2 + " là nghiệm của phương trình";
            //Gọi phương thức KiemTraX_86_Nhi truyền tham số 2 để kiểm tra và gán vào biến actual_86_Nhi
            actual_86_Nhi = pt_86_Nhi.KiemTraX_86_Nhi(2);
            //So sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_86_Nhi, actual_86_Nhi);
        }
        //Nghiệm không thuộc phương trình
        [TestMethod]
        public void TestNghiemKhongThuoc_86_Nhi()
        {
            //Khai báo 2 biến kiểu string
            string expected_86_Nhi, actual_86_Nhi;
            //Khởi tạo một đối tưởng mới của lớp PhuongTrinh_86_Nhi và gán vào biến pt_86_Nhi
            pt_86_Nhi = new PhuongTrinh_86_Nhi(1, -5, 6);
            //Gán kết quả mong đợi vào biến expected_86_Nhi
            expected_86_Nhi = 1 + " không là nghiệm của phương trình";
            //Gọi phương thức KiemTraX_86_Nhi truyền tham số 1 để kiểm tra và gán vào biến actual_86_Nhi
            actual_86_Nhi = pt_86_Nhi.KiemTraX_86_Nhi(1);
            //So sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_86_Nhi, actual_86_Nhi);
        }
        

        //liên kết Testdata tìm nghiệm với project
        [TestMethod]
        //Dùng để chỉ định nguồn dữ liệu cho kiểm thử, nguồn dữ liệu được cung cấp từ một tệp CSV
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data_86_Nhi\TestDataTimNghiem_86_Nhi.csv", "TestDataTimNghiem_86_Nhi#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource_TimNghiem_86_Nhi()
        {
            //Khai báo 3 biến kiểu int
            int a_86_Nhi, b_86_Nhi, c_86_Nhi;
            //Khai báo 2 biến kiểu string
            string expected_86_Nhi, actual_86_Nhi;
            //Lấy giá trị trong nguồn dữ liệu sau đó gán vào biến, giá trị được lấy ở cột đầu tiên
            a_86_Nhi = int.Parse(TestContext.DataRow[0].ToString());
            //Lấy giá trị trong nguồn dữ liệu sau đó gán vào biến, giá trị được lấy ở cột thứ 2
            b_86_Nhi = int.Parse(TestContext.DataRow[1].ToString());
            //Lấy giá trị trong nguồn dữ liệu sau đó gán vào biến, giá trị được lấy ở cột thứ 3
            c_86_Nhi = int.Parse(TestContext.DataRow[2].ToString());
            //Chuyển đổi dữ liệu từ một kiểu mã hóa sang kiểu chuỗi và gán vào biến expected_86_Nhi
            expected_86_Nhi = Encoding.UTF8.GetString(Encoding.Default.GetBytes(TestContext.DataRow.ItemArray[3].ToString()));
            //Khởi tạo một đối tượng mới của lớp PhuongTrinh_86_Nhi, sau đó gán vào biến pt_86_Nhi
            pt_86_Nhi = new PhuongTrinh_86_Nhi(a_86_Nhi, b_86_Nhi, c_86_Nhi);
            //Gọi phương thức GiaiPT_86_Nhi() để giải sau đó sẽ xóa các kí tự "\n" và "\r"
            actual_86_Nhi = pt_86_Nhi.GiaiPT_86_Nhi().Replace("\n", "").Replace("\r", "");
            //So sánh kết quả mong đợi với kết quả thực tế
            Assert.AreEqual(expected_86_Nhi, actual_86_Nhi);
        }

        //liên kết Testdata kiểm tra nghiệm với project
        [TestMethod]
        //Dùng để chỉ định nguồn dữ liệu cho kiểm thử, nguồn dữ liệu được cung cấp từ một tệp CSV
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data_86_Nhi\TestDataKTNghiem_86_Nhi.csv", "TestDataKTNghiem_86_Nhi#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource_KTNghiem_86_Nhi()
        {
            //Khai báo 4 biến kiểu int
            int a_86_Nhi, b_86_Nhi, c_86_Nhi, x_86_Nhi;
            //Khai báo 2 biến kiểu string
            string expected_86_Nhi, actual_86_Nhi;
            //Lấy giá trị trong nguồn dữ liệu sau đó gán vào biến, giá trị được lấy ở cột đầu tiên
            a_86_Nhi = int.Parse(TestContext.DataRow[0].ToString());
            //Lấy giá trị trong nguồn dữ liệu sau đó gán vào biến, giá trị được lấy ở cột thứ 2
            b_86_Nhi = int.Parse(TestContext.DataRow[1].ToString());
            //Lấy giá trị trong nguồn dữ liệu sau đó gán vào biến, giá trị được lấy ở cột thứ 3
            c_86_Nhi = int.Parse(TestContext.DataRow[2].ToString());
            //Lấy giá trị trong nguồn dữ liệu sau đó gán vào biến, giá trị được lấy ở cột thứ 4
            x_86_Nhi = int.Parse(TestContext.DataRow[3].ToString());
            //Chuyển đổi dữ liệu từ một kiểu mã hóa sang kiểu chuỗi và gán vào biến expected_86_Nhi
            expected_86_Nhi = Encoding.UTF8.GetString(Encoding.Default.GetBytes(TestContext.DataRow.ItemArray[4].ToString()));
            //Khởi tạo một đối tượng mới của lớp PhuongTrinh_86_Nhi, sau đó gán vào biến pt_86_Nhi
            pt_86_Nhi = new PhuongTrinh_86_Nhi(a_86_Nhi, b_86_Nhi, c_86_Nhi);
            //Gọi phương thức GiaiPT_86_Nhi() để giải và gán kết quả vào biến actual_86_Nhi
            actual_86_Nhi = pt_86_Nhi.KiemTraX_86_Nhi(x_86_Nhi);
            //So sánh kết quả mong đợi với kết quả thực tế
            Assert.AreEqual(expected_86_Nhi, actual_86_Nhi);
        }
    }
}
