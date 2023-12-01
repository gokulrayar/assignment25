using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    
    public class Validation
    {
        private string name;
        private string password;

        public string Name
        {
            get { return name; }
        }

        public string Password
        {
            get { return password; }
        }

        public void Validate(string username,string pass)
        {
            if(username.Length<=25 && pass.Length == 8) 
            {
               name = username;
               password = pass;
            }
            else
            {
                Console.WriteLine("Username must be less than or equal to 25 characters and Password must be 8 characters ");
            }
        }
    }
}
