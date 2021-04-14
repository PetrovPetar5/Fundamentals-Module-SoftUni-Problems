namespace PasswordValidator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string passwordToCheck = Console.ReadLine();
            bool lengthMet = PasswordLengthRequirementCheck(passwordToCheck);
            bool lettersAndDigitmet = ChecksIfOnlyLettersAndDigits(passwordToCheck);
            bool digitmet = ChecksIfTwoDigits(passwordToCheck);

            if (lengthMet && lettersAndDigitmet && digitmet)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool PasswordLengthRequirementCheck(string passwordToCheck)
        {
            bool isValid = true;
            int minPasswordLenghtRequirement = 6;
            int maxPasswordLenghtRequirement = 10;
            if (minPasswordLenghtRequirement > passwordToCheck.Length || passwordToCheck.Length > maxPasswordLenghtRequirement)
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            return isValid;
        }
        static bool ChecksIfOnlyLettersAndDigits(string passwordToCheck)
        {
            bool isValid = true;
            for (int i = 0; i < passwordToCheck.Length; i++)
            {
                int curCharCheck = passwordToCheck[i];

                if (!((curCharCheck >= 48 && curCharCheck <= 57) || (curCharCheck >= 65 && curCharCheck <= 90) || (curCharCheck >= 97 && curCharCheck <= 122)))
                {
                    isValid = false;
                    if (!isValid)
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                    }

                    break;
                }
            }

            return isValid;
        }

        static bool ChecksIfTwoDigits(string passwordToCheck)
        {
            bool isValid = true;
            int digitsC = 0;
            for (int i = 0; i < passwordToCheck.Length; i++)
            {
                int curCheck = passwordToCheck[i];
                if (curCheck >= 48 && curCheck <= 57)
                {
                    digitsC++;
                }
            }

            int minDigitCountRequirement = 2;
            if (digitsC < minDigitCountRequirement)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            return isValid;
        }
    }
}
