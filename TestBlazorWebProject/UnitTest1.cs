//namespace TestBlazorWebProject
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }

//        [Test]
//        public void Test1()
//        {
//            Assert.Pass();
//        }
//    }
//}

using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace TestBlazorWebProject
{
    //public class Tests
    //{
    //    [Test]
    //    public void SecondSeleniumTest()
    //    {
    //        var edgeOptions = new EdgeOptions();
    //        IWebDriver driver = new EdgeDriver(@"C:\edgedriver_win64\msedgedriver.exe", edgeOptions);
    //        try
    //        {
    //            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
    //            driver.Navigate().GoToUrl("https://localhost:7266/");
    //            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

    //            // ������ ������� Add/Edit book
    //            IWebElement addWindow = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/nav[1]/div[2]/a[1]")));
    //            addWindow.Click();

    //            // �������� ���� ����� � ����������� � �����
    //            string bookTitle = "������� ������";
    //            IWebElement addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[1]/input[1]")));
    //            addBox.Click();
    //            addBox.SendKeys("������");
    //            addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[2]/input[1]")));
    //            addBox.Click();
    //            addBox.SendKeys(bookTitle);
    //            addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[3]/input[1]")));
    //            addBox.Click();
    //            addBox.SendKeys("1900");

    //            // �������� ����������� �����
    //            string imagePath = @"C:\Users\ZenBook\Downloads\���������.jpg";
    //            IWebElement element = driver.FindElement(By.Id("image"));
    //            element.SendKeys(imagePath);

    //            // ������ ������ "��������"
    //            IWebElement addButton = wait.Until(d => d.FindElement(By.CssSelector("button[type='submit']")));
    //            addButton.Click();

    //            // ������ ������� �� ��������, ���������� �������� ����� "������� ������"
    //            IWebElement bookElement = wait.Until(d => d.FindElement(By.XPath($"//div[contains(text(), '{bookTitle}')]")));


    //            Assert.IsNotNull(bookElement);
    //            //Assert.Contains(bookElement, bookElement.Text(bookElement));

    //            //�������� �� ������� ���������
    //            IWebElement mainWindow = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/nav[1]/div[1]/a[1]")));
    //            mainWindow.Click();

    //            //�������� �� ������ ������
    //            IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/div[1]/form[1]/button[1]")));
    //            searchBox.SendKeys(Keys.Enter);

    //            //������� �� ��������� ������ � ����
    //            searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
    //            searchBox.Click();
    //            searchBox.SendKeys(bookTitle);
    //            //searchBox.SendKeys(Keys.Enter);
    //            //�������� �� ������ �����
    //            searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
    //            searchBox.Click();

    //            //��������� ���� �� �����
    //            searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'������ ������ - ����� ��������� (2012)')]")));
    //            bool a = searchBox.Text == "������ ������ - ����� ��������� (2012)";
    //            Assert.IsTrue(searchBox.Text == "������ ������ - ����� ��������� (2012)");

    //        }
    //        catch (WebDriverTimeoutException ex)
    //        {
    //            Console.WriteLine($"������ WebDriverTimeoutException: {ex.Message}");
    //        }
    //        finally
    //        {
    //            // �������� �����������
    //            driver.Quit();
    //        }
    //    }

    //}
    [TestFixture]
    public class BookstoreTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        
        [SetUp]
        public void Setup()
        {
            var edgeOptions = new EdgeOptions();
            driver = new EdgeDriver(@"C:\edgedriver_win64\msedgedriver.exe", edgeOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            
        }

        [Test]
        public void AddEditBookPageNavigationTest()
        {
            driver.Navigate().GoToUrl("https://localhost:7266/");
            Thread.Sleep(2000);
            IWebElement addWindow = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/nav[1]/div[2]/a[1]")));
            addWindow.Click();
            Thread.Sleep(2000);
            string bookTitle = "������� ������";
            IWebElement addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[1]/input[1]")));
            addBox.Click();
            addBox.SendKeys("������");
            addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[2]/input[1]")));
            addBox.Click();
            addBox.SendKeys(bookTitle);
            addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[3]/input[1]")));
            addBox.Click();
            addBox.SendKeys("1900");
            string imagePath = @"C:\Users\ZenBook\Downloads\���������.jpg";
            IWebElement element = driver.FindElement(By.Id("image"));
            element.SendKeys(imagePath);

            IWebElement addButton = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/button[1]")));
            addButton.Click();
            Thread.Sleep(1000);
            //CssSelector("button[type='submit']")
        }

        [Test]
        public void BuyBookTest()
        {
            driver.Navigate().GoToUrl("https://localhost:7266/");
            Thread.Sleep(2000);

            IWebElement bookRow = wait.Until(d => d.FindElement(By.XPath("//a[contains(text(),'������� ������')]/ancestor::tr")));

            try
            {
                IWebElement buyButton = bookRow.FindElement(By.XPath(".//button[contains(text(),'������')]"));

                buyButton.Click();

                // ������: �������� ��������� ��������� ��������
                wait.Until(d => d.Title != "�������� ��������...");

            }
            catch (StaleElementReferenceException ex)
            {
                Console.WriteLine($"������ StaleElementReferenceException: {ex.Message}");
            }
            // ����� ������ "������"
            //IWebElement buyButton = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'������')]")));
            //IWebElement buyButton = wait.Until(d => d.FindElement(By.XPath("//a[contains(text(),'������� ������')]/ancestor::tr//button[contains(text(),'������')]")));

            //try
            //{
            //    // ������ ������ "������"
            //    buyButton.Click();
            //}
            //catch (StaleElementReferenceException)
            //{
            //    // ���� ������� �������, ��������� ����� ��� �����
            //    buyButton = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'������')]")));
            //    buyButton.Click();
            //}
        }

        [Test]
        public void TestPurchasedBookPresence()
        {
            driver.Navigate().GoToUrl("https://localhost:7266/");
            Thread.Sleep(2000);
            IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='�����']")));
            string purchasedBookTitle = "������� ������"; 
            searchBox.SendKeys(purchasedBookTitle);

            IWebElement searchButton = driver.FindElement(By.XPath("//button[contains(text(),'�����')]"));
            searchButton.Click();
            Thread.Sleep(5000);

            try
            {
                // ����� ������ ����� � ���������� ������
                IWebElement firstBookElement = driver.FindElement(By.XPath("//tbody/tr[1]/td[2]/a"));

                // �������� �������� ������ �����
                string firstBookTitle = firstBookElement.Text;

                // �������� �������� ��������� ����� � ������ ��������� �����
                if (firstBookTitle == purchasedBookTitle)
                {
                    Assert.Fail("��������� ����� ������������ �� �����.");
                }
            }
            catch (NoSuchElementException)
            {
                Assert.Pass("��������� ����� �� ������� �� �����.");
            }
        }
        [Test]
        public void TestSearchBook()
        {
            driver.Navigate().GoToUrl("https://localhost:7266/");
            Thread.Sleep(2000);
            IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='�����']")));
            string purchasedBookTitle = "���";
            searchBox.SendKeys(purchasedBookTitle);

            IWebElement searchButton = driver.FindElement(By.XPath("//button[contains(text(),'�����')]"));
            searchButton.Click();
            Thread.Sleep(5000);

            try
            {
                // ����� ������ ����� � ���������� ������
                IWebElement firstBookElement = driver.FindElement(By.XPath("//tbody/tr[1]/td[2]/a"));

                // �������� �������� ������ �����
                string firstBookTitle = firstBookElement.Text;

                // �������� �������� ��������� ����� � ������ ��������� �����
                if (firstBookTitle == purchasedBookTitle)
                {
                    Assert.Pass("��������� ����� ������������ �� �����.");
                }
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("��������� ����� �� ������� �� �����.");
            }
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
