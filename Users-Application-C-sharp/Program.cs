using System;
using Users_Application_C_sharp.Users;
namespace Users_Application_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UsersService.ValidatePassword("12kkkks");
            UsersService.ValidatePassword("avvvkkkks");

            UsersService.ValidatePassword("2324223423");

            UsersService.ValidatePassword("ab123569");

            UsersService.ValidatePassword("khfk#jjl12");



        }
    }
}
