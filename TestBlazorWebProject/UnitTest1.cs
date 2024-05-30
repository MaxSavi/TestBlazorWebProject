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

    //            // Найдем вкладку Add/Edit book
    //            IWebElement addWindow = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/nav[1]/div[2]/a[1]")));
    //            addWindow.Click();

    //            // Заполним поля ввода с информацией о книге
    //            string bookTitle = "Евгений Онегин";
    //            IWebElement addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[1]/input[1]")));
    //            addBox.Click();
    //            addBox.SendKeys("Пушкин");
    //            addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[2]/input[1]")));
    //            addBox.Click();
    //            addBox.SendKeys(bookTitle);
    //            addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[3]/input[1]")));
    //            addBox.Click();
    //            addBox.SendKeys("1900");

    //            // Загрузим изображение книги
    //            string imagePath = @"C:\Users\ZenBook\Downloads\грибоедов.jpg";
    //            IWebElement element = driver.FindElement(By.Id("image"));
    //            element.SendKeys(imagePath);

    //            // Нажмем кнопку "Добавить"
    //            IWebElement addButton = wait.Until(d => d.FindElement(By.CssSelector("button[type='submit']")));
    //            addButton.Click();

    //            // Найдем элемент на странице, содержащий название книги "Евгений Онегин"
    //            IWebElement bookElement = wait.Until(d => d.FindElement(By.XPath($"//div[contains(text(), '{bookTitle}')]")));


    //            Assert.IsNotNull(bookElement);
    //            //Assert.Contains(bookElement, bookElement.Text(bookElement));

    //            //Перейдем на главную страничку
    //            IWebElement mainWindow = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/nav[1]/div[1]/a[1]")));
    //            mainWindow.Click();

    //            //Нажимаем на кнопку КУПИТЬ
    //            IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/div[1]/form[1]/button[1]")));
    //            searchBox.SendKeys(Keys.Enter);

    //            //Кликаем на поисковую строку и ищем
    //            searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
    //            searchBox.Click();
    //            searchBox.SendKeys(bookTitle);
    //            //searchBox.SendKeys(Keys.Enter);
    //            //Нажимаем на кнопку найти
    //            searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'Поиск')]")));
    //            searchBox.Click();

    //            //Проверяем есть ли товар
    //            searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'Тайные истоки - Ольга Николаева (2012)')]")));
    //            bool a = searchBox.Text == "Тайные истоки - Ольга Николаева (2012)";
    //            Assert.IsTrue(searchBox.Text == "Тайные истоки - Ольга Николаева (2012)");

    //        }
    //        catch (WebDriverTimeoutException ex)
    //        {
    //            Console.WriteLine($"Ошибка WebDriverTimeoutException: {ex.Message}");
    //        }
    //        finally
    //        {
    //            // Проверка результатов
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
            string bookTitle = "Евгений Онегин";
            IWebElement addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[1]/input[1]")));
            addBox.Click();
            addBox.SendKeys("Пушкин");
            addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[2]/input[1]")));
            addBox.Click();
            addBox.SendKeys(bookTitle);
            addBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/article[1]/form[1]/div[3]/input[1]")));
            addBox.Click();
            addBox.SendKeys("1900");
            string imagePath = @"C:\Users\ZenBook\Downloads\грибоедов.jpg";
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

            IWebElement bookRow = wait.Until(d => d.FindElement(By.XPath("//a[contains(text(),'Евгений Онегин')]/ancestor::tr")));

            try
            {
                IWebElement buyButton = bookRow.FindElement(By.XPath(".//button[contains(text(),'Купить')]"));

                buyButton.Click();

                // Пример: ожидание появления заголовка страницы
                wait.Until(d => d.Title != "Страница загрузки...");

            }
            catch (StaleElementReferenceException ex)
            {
                Console.WriteLine($"Ошибка StaleElementReferenceException: {ex.Message}");
            }
            // Найти кнопку "Купить"
            //IWebElement buyButton = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'Купить')]")));
            //IWebElement buyButton = wait.Until(d => d.FindElement(By.XPath("//a[contains(text(),'Евгений Онегин')]/ancestor::tr//button[contains(text(),'Купить')]")));

            //try
            //{
            //    // Нажать кнопку "Купить"
            //    buyButton.Click();
            //}
            //catch (StaleElementReferenceException)
            //{
            //    // Если элемент устарел, попробуем найти его снова
            //    buyButton = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'Купить')]")));
            //    buyButton.Click();
            //}
        }

        [Test]
        public void TestPurchasedBookPresence()
        {
            driver.Navigate().GoToUrl("https://localhost:7266/");
            Thread.Sleep(2000);
            IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Поиск']")));
            string purchasedBookTitle = "Евгений Онегин"; 
            searchBox.SendKeys(purchasedBookTitle);

            IWebElement searchButton = driver.FindElement(By.XPath("//button[contains(text(),'Поиск')]"));
            searchButton.Click();
            Thread.Sleep(5000);

            try
            {
                // Найти первую книгу в результате поиска
                IWebElement firstBookElement = driver.FindElement(By.XPath("//tbody/tr[1]/td[2]/a"));

                // Получить название первой книги
                string firstBookTitle = firstBookElement.Text;

                // Сравнить названия купленной книги и первой найденной книги
                if (firstBookTitle == purchasedBookTitle)
                {
                    Assert.Fail("Купленная книга присутствует на сайте.");
                }
            }
            catch (NoSuchElementException)
            {
                Assert.Pass("Купленная книга не найдена на сайте.");
            }
        }
        [Test]
        public void TestSearchBook()
        {
            driver.Navigate().GoToUrl("https://localhost:7266/");
            Thread.Sleep(2000);
            IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Поиск']")));
            string purchasedBookTitle = "Ура";
            searchBox.SendKeys(purchasedBookTitle);

            IWebElement searchButton = driver.FindElement(By.XPath("//button[contains(text(),'Поиск')]"));
            searchButton.Click();
            Thread.Sleep(5000);

            try
            {
                // Найти первую книгу в результате поиска
                IWebElement firstBookElement = driver.FindElement(By.XPath("//tbody/tr[1]/td[2]/a"));

                // Получить название первой книги
                string firstBookTitle = firstBookElement.Text;

                // Сравнить названия купленной книги и первой найденной книги
                if (firstBookTitle == purchasedBookTitle)
                {
                    Assert.Pass("Купленная книга присутствует на сайте.");
                }
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Купленная книга не найдена на сайте.");
            }
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
