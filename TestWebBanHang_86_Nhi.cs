using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace WebDriver_TestWebBanHang_86_Nhi
{
    [TestClass]
    public class TestWebBanHang_86_Nhi
    {
        private ChromeDriverService chrome_86_Nhi;
        private IWebDriver driver_86_Nhi;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Initialize_86_Nhi()
        {
            chrome_86_Nhi = ChromeDriverService.CreateDefaultService();
            chrome_86_Nhi.HideCommandPromptWindow = true;
            driver_86_Nhi = new ChromeDriver(chrome_86_Nhi);
        }
        //Chức năng 1: Đăng nhập
        //liên kết Testdata đăng nhập với project
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data_LogIn_86_Nhi\TestDataLogIn_86_Nhi.csv", "TestDataLogIn_86_Nhi#csv", DataAccessMethod.Sequential)]
        public void TC1_LogInSuccess_86_Nhi()
        {
            //khai báo biến kiểu chuỗi
            string email_86_Nhi, pass_86_Nhi;
            //Lấy giá trị cột đầu tiên của hàng hiện tại và gán vào biến email_86_Nhi
            email_86_Nhi = TestContext.DataRow[0].ToString();
            //Lấy giá trị cột thứ hai của hàng hiện tại và gán vào biến pass_86_Nhi
            pass_86_Nhi = TestContext.DataRow[1].ToString();
            //Vào trình duyệt, điều hướng đến URL
            driver_86_Nhi.Navigate().GoToUrl("https://yody.vn/");
            //Tìm phần tử có thẻ a là "ĐĂNG NHẬP", sau đó sử dụng phương thức Click()
            driver_86_Nhi.FindElement(By.LinkText("ĐĂNG NHẬP")).Click();
            //Tìm phần tử <input> có thuộc tính type='email' và nhập giá trị của biến email_86_Nhi
            driver_86_Nhi.FindElement(By.CssSelector("input[type='email']")).SendKeys(email_86_Nhi);
            //Dùng By.XPath để lấy dựa trên chuỗi XPath và nhập giá trị của biến pass_86_Nhi
            driver_86_Nhi.FindElement(By.XPath("//*[@id=\"customer_password\"]")).SendKeys(pass_86_Nhi);
            //Dùng By.ClassName để lấy phần tử class là "btn-login" sau đó dùng phương thức Click()
            driver_86_Nhi.FindElement(By.ClassName("btn-login")).Click();
        }

        //Chức năng 2: Tìm kiếm sản phẩm và xem chi tiết
        [TestMethod]
        public void TC1_SearchInStore_86_Nhi()
        {
            //TC1: Tìm kiếm sản phẩm có trong cửa hàng
            //Vào trình duyệt, điều hướng đến URL
            driver_86_Nhi.Navigate().GoToUrl("https://yody.vn/");
            //Dùng By.CssSelector để lấy ra phần tử có selector là "input[type='text']" và gửi giá trị "Quần"
            driver_86_Nhi.FindElement(By.CssSelector("input[type='text']")).SendKeys("Quần");
            // Dùng By.XPath để lấy dựa trên chuỗi XPath sau đó dùng phương thức Click()
            driver_86_Nhi.FindElement(By.XPath("//*[@id=\"header-search-product\"]/button")).Click();
            //Tìm phần tử có thẻ a là "Quần Jean Nam Coolmax Mác Logo Đỉa Quần", sau đó sử dụng phương thức Click()
            driver_86_Nhi.FindElement(By.LinkText("Quần Jean Nam Coolmax Mác Logo Đỉa Quần")).Click();
        }

        [TestMethod]
        public void TC2_SearchOutStore_86_Nhi()
        {
            //TC2: Tìm kiếm sản phẩm không có trong cửa hàng
            //Vào trình duyệt, điều hướng đến URL
            driver_86_Nhi.Navigate().GoToUrl("https://yody.vn/");
            //Dùng By.Name để lấy phần tử có name là "query", sau đó gửi giá trị "Xe máy" lên
            driver_86_Nhi.FindElement(By.Name("query")).SendKeys("Xe máy");
            //Dùng By.XPath để lấy dựa trên chuỗi XPath sau đó dùng phương thức Click()
            driver_86_Nhi.FindElement(By.XPath("//*[@id=\"header-search-product\"]/button")).Click();
        }

        //Chức năng 3: Thêm sản phẩm vào giỏ hàng
        [TestMethod]
        public void TC1_AddSuccess_86_Nhi()
        {
            //TC1: Thêm sản phẩm thành công
            //Vào trình duyệt, và điều hướng đến URL
            driver_86_Nhi.Navigate().GoToUrl("https://yody.vn/quan-jean-nam-coolmax-mac-logo-dia-quan");
            //Khởi tạo một đối tượng Actions để thực hiện thao tác với trình duyệt
            Actions actions_86_Nhi = new Actions(driver_86_Nhi);
            //Tìm phần tử trên trang có thuộc tính id là "swatch-1-30" và gán vào biến element_86_Nhi
            IWebElement element_86_Nhi = driver_86_Nhi.FindElement(By.Id("swatch-1-30"));
            //Di chuyển chuột đến phần tử element_86_Nhi sau đó thực hiện thao tác nhấp chuột.
            actions_86_Nhi.MoveToElement(element_86_Nhi).Click().Perform();
            //Tìm phần tử trên trang bằng cách sử dụng XPath là "/html/body/div[7]/div/div[2]/button" và gán vào biến submitElement_86_Nhi
            IWebElement submitElement_86_Nhi = driver_86_Nhi.FindElement(By.XPath("/html/body/div[7]/div/div[2]/button"));
            //Di chuyển chuột đến phần tử submitElement_86_Nhi sau đó thực hiện thao tác nhấp chuột.
            actions_86_Nhi.MoveToElement(submitElement_86_Nhi).Click().Perform();
        }

        [TestMethod]
        public void TC2_AddFail_86_Nhi()
        {
            //TC2: Thêm sản phẩm không thành công
            //Vào trình duyệt, và điều hướng đến địa chỉ URL
            driver_86_Nhi.Navigate().GoToUrl("https://yody.vn/giay-dep-cao-got-quai-ngang");
            //Khởi tạo một đối tượng Actions để thực hiện thao tác với trình duyệt
            Actions actions_86_Nhi = new Actions(driver_86_Nhi);
            //Tìm phần tử trên trang bằng cách sử dụng XPath là "/html/body/section/div[4]/div[1]/div[2]/div/form/div/div[1]/div[1]/div[1]/div[4]/label/span" và gán vào biến element_86_Nhi
            IWebElement element_86_Nhi = driver_86_Nhi.FindElement(By.XPath("/html/body/section/div[4]/div[1]/div[2]/div/form/div/div[1]/div[1]/div[1]/div[4]/label/span"));
            //Di chuyển chuột đến phần tử element_86_Nhi sau đó thực hiện thao tác nhấp chuột.
            actions_86_Nhi.MoveToElement(element_86_Nhi).Click().Perform();
            //Dùng By.Id để lấy phần tử có id là "swatch-1-39"
            IWebElement sizeElement_86_Nhi = driver_86_Nhi.FindElement(By.Id("swatch-1-39"));
            if (sizeElement_86_Nhi.Selected)
            {
                //Tìm phần tử trên trang bằng cách sử dụng ClassName là "add-span-cart" và gán vào biến submitElement_86_Nhi
                IWebElement submitElement_86_Nhi = driver_86_Nhi.FindElement(By.ClassName("add-span-cart"));
                //Di chuyển chuột đến ohaanf tử submitElement_86_Nhi sau đó thực hiện thao tác nhấp chuột.
                actions_86_Nhi.MoveToElement(submitElement_86_Nhi).Click().Perform();
            }
            else
            {
                //Nếu như kích thước chưa được chọn thì sẽ xuất ra dòng để thông báo
                Console.WriteLine("Lỗi: Bạn chưa chọn kích thước sản phẩm");
            }
        }

        /* [TestCleanup]
         public void Cleanup()
         {
             driver_86_Nhi.Quit();
         }*/
    }
}
