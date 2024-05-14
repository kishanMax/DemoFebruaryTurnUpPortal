
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);
IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
userNameTextBox.SendKeys("hari");
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
Thread.Sleep(3000);
IWebElement loginVerificationMessage = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (loginVerificationMessage.Text == "Hello hari")
{
    Console.WriteLine("User Logged In  Successfully :");
}else
{
    Console.WriteLine("User was unable to login :");
}
    

