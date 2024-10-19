using System.Text.RegularExpressions;

namespace RealEstateApp.Api.DTO.AuthDTO
{
    public class RegisterRequestDTO
    {
        public string Username { get; set; }

        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        private bool CheckUsername()
        {
            return Regex.IsMatch(Username, pattern: "^[a-z0-9]+$");
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return false;
            }

            phoneNumber = phoneNumber.Trim();

            if (!phoneNumber.All(char.IsDigit))
            {
                return false;
            }

            if (phoneNumber.Length != 10)
            {
                return false;
            }

            // Ensure the phone number doesn't start with 0 or 1
            if (phoneNumber[0] == '0' || phoneNumber[0] == '1')
            {
                return false;
            }

            // Prevent all digits from being the same (e.g., 1111111111)
            if (phoneNumber.Distinct().Count() == 1)
            {
                return false;
            }

            // Prevent sequential numbers (e.g., 1234567890 or 9876543210)
            if ("1234567890".Contains(phoneNumber) || "0987654321".Contains(phoneNumber))
            {
                return false;
            }

            return true;
        }


        private bool CheckPassword()
        {
            // Check for at least 1 capital letter
            if (!Regex.IsMatch(Password, pattern: "[A-Z]"))
                return false;

            // Check for at least 1 lowercase letter
            if (!Regex.IsMatch(Password, pattern: "[a-z]"))
                return false;

            // Check for at least 1 of the specified symbols
            if (!Regex.IsMatch(Password, pattern: "[.,-;]"))
                return false;

            // Check for at least 1 number
            if (!Regex.IsMatch(Password, pattern: "[0-9]"))
                return false;

            // Check the length condition
            if (Password.Length < 8 || Password.Length > 12)
                return false;

            // All conditions are satisfied
            return true;
        }

        public bool IsValid()
        {
            Username = Username.Trim();
            PhoneNumber = PhoneNumber.Trim();
            Password = Password.Trim();
            return CheckUsername() && IsValidPhoneNumber(PhoneNumber) && CheckPassword();
        }


    }
}
