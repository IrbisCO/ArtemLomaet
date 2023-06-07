using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtemLomaet
{
    public class Generate
    {
        string prefix = "Темка красавчик!";
        public string GenerateRandomEmail()
        {
            string randomString = Guid.NewGuid().ToString("N").Substring(0, 3);
            string email = $"ArtemMolodec@{randomString}.IRBIS";
            return email;
        }

        public string GenerateRandomName()
        {           
            string randomString = Guid.NewGuid().ToString("N").Substring(0, 3);
            randomString = prefix + " " + randomString;
            return randomString;
        }

        public string GenerateRandomPassword()
        {
            string randomString = Guid.NewGuid().ToString("N").Substring(0, 3);
            randomString = prefix + " " + randomString;
            return randomString;
        }
    }
}
