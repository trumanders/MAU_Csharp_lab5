using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace MAU_Csharp_lab5.ContactData
{
    public class Phone
    {
        private string privatePhone;
        private string officePhone;

        public Phone(string privatePhone, string officePhone)
        {
            this.privatePhone = privatePhone;
            this.officePhone = officePhone;
        }

        public string GetPrivatePhone()
        {
            return privatePhone;
        }


        public string GetOfficePhone()
        {
            return officePhone;
        }
    }
}
