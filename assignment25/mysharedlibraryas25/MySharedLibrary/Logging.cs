using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class Logging
    {
        public void Login(Validation validator,string username,string pass)
        {
            if(validator.Name==username&&validator.Password==pass)
            {
                Console.WriteLine("Login Sucessful");
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }
        }
    }
}
