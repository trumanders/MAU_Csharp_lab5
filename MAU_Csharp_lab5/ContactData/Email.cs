using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAU_Csharp_lab5.ContactData
{
    public class Email
    {
        private string privateEmail;
        private string officeEmail;

        public Email(string privateEmail, string officeEmail)
        {
            this.privateEmail = privateEmail;
            this.officeEmail = officeEmail;
        }

        public string GetPrivateEmail()
        {
            return privateEmail;
        }


        public string GetOfficeEmail()
        {
            return officeEmail;
        }
    }
}
