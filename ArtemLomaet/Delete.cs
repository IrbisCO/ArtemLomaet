using OpenQA.Selenium;

namespace ArtemLomaet
{
    [TestFixture]
    public class Delete : BaseClass
    {
        [Test]
        [Repeat(2)]
        public void DeleteUser()
        {
            driver.Navigate().GoToUrl("http://users.bugred.ru/user/admin/");

            string emailXPath = "(//tbody[@class='ajax_load_row']/tr/td[1])[1]";
            IWebElement emailElement = driver.FindElement(By.XPath(emailXPath));
            string email = emailElement.Text;
            Console.WriteLine(email);

            HttpClient client = new HttpClient();
            var response = client.PostAsync("http://users.bugred.ru/tasks/rest/deleteuser?email=" + email, null).Result;
            Console.WriteLine(response);
        }
    }
}
