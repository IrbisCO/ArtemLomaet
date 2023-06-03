using OpenQA.Selenium;

namespace ArtemLomaet
{
    [TestFixture]
    public class Create : Generate
    {
        [Test]
        [Repeat(5)]
        public void CreateUserForArtem()
        {
            string email = GenerateRandomEmail();
            string name = GenerateRandomName();
            string password = GenerateRandomPassword();

            var user = new
            {
                Email = email,
                Name = name,
                Password = password
            };

            HttpClient client = new HttpClient();
            var response = client.PostAsync("http://users.bugred.ru/tasks/rest/doregister?email=" + email + "&name=" + name + "&password=" + password, null).Result;
        }
    }
}
