using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LD
{
    /// <summary>
    /// Summary description for LDService
    /// </summary>
    [WebService(Namespace = "http://laundryservice.com/delivery/alwaysready")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LDService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double Add(double val1 , double val2)
        {
            return val1 * val2;
        }

       
        //public class RegisterModel
        //{

        //    public string Firstname { get; set; }
        //    public string Lastname { get; set; }
        //    public string EmailAddress { get; set; }
        //    public string Password { get; set; }
        //    public string APassword { get; set; }
        //    public string Additional { get; set; }
        //    public string PhoneNUmber { get; set; }
        //    public string APhoneNUmber { get; set; }
        //    public string Address { get; set; }
        //    public string Userrole { get; set; }
        //    public string Adminrole { get; set; }

        //}
        [WebMethod]
        public string Registertodatabase(string firstname, string lastname, string emailaddress, string phonenumber, string aphonenumber, string addresss, string password)
        {
            try
            {
                using (var db = new LDServiceEntities())
                {
                    db.Configuration.ProxyCreationEnabled = false;
                    var user = new C_tblRegister();
                    user.Firstname = firstname;
                    user.Lastname = lastname;
                    user.Password = password;
                    user.PhoneNumber = phonenumber;
                    user.Userrole = "1";
                    user.EmailAddress = emailaddress;
                    user.APhoneNumber = aphonenumber;
                    user.Address = addresss;
                    db.C_tblRegister.Add(user);
                    db.SaveChanges();
                }
                string msg = "Registration Successfully Done !!!";
                string value = "1";
                return msg;

            }
            catch (Exception Ex)
            {
                string message = "Registration Unsuccessful";
                return message;
            }

           

        }
    }
}
