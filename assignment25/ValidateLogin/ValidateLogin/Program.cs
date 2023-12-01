using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Here I didnt store the username and password anywhere I did both validation and login at same time as there is no database 
//if we enter username of length less than or equal to 25 and password of length 8 we can sucessfully login 
namespace ValidateLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySharedLibrary.Validation validator = new MySharedLibrary.Validation();

            
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            
            Console.WriteLine($"Entered username: {username}");
            Console.WriteLine($"Entered password: {password}");

            UserManagementModule.ValidateAndLogin(validator, username, password);

            
            UserManagementModule.DisplayLoginResult(username);

           
            Console.WriteLine("MainApp is running.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    public static class UserManagementModule
    {
        private static MySharedLibrary.Logging logger = new MySharedLibrary.Logging();

        public static void ValidateAndLogin(MySharedLibrary.Validation validator, string username, string password)
        {
           
            validator.Validate(username, password);

            
            Console.WriteLine($"Name after validation: {validator.Name}");
            Console.WriteLine($"Password after validation: {validator.Password}");

           
            logger.Login(validator,validator.Name, validator.Password);
        }

        public static void DisplayLoginResult(string username)
        {
            Console.WriteLine($"Hello {username} Welcome to MainApp");
        }
    }
   
}
