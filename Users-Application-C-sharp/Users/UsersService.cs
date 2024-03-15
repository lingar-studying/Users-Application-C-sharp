using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Application_C_sharp.Users
{
    public class UsersService
    {
        public static bool ValidatePassword(string password)
        {

            //check if it's between 8 to 16 
            if(password.Length < 8 || password.Length > 16)
            {
                Console.WriteLine("password length should be 8-16 chars ");
                return false;
            }

            int countDigits = 0, countLetters = 0;
            for (int i = 0; i < password.Length; i++)

            {

                int charI = password[i];

                //[65-90] - Capital  [97-122] [a-z]Low case
                //48 – 57 - digits
                //if it's a letter
                if ((charI >= 65 && charI <= 90) || (charI >= 97 && charI <= 122))
                {
                    countLetters++;
                }
               //if it's a digit
                else if(charI >= 65 && charI <= 90)
                {
                    countDigits++;
                }
                else{
                    Console.WriteLine("You must insert digits or english letters only! ");
                    return false;
                }
                //check if it has digits

                //check if it's has English letters

                //check if it has no other chars
            }

            if(countDigits <= 0 || countLetters <= 0)
            {
                Console.WriteLine("You must type digits and english letters ");
                return false;
            }


            Console.WriteLine("the password is well");
            return true;
        }

    }
}
