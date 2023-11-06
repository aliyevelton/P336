namespace UserClass
{
    public class User
    {
        public int Id { get; set; } = 1;
        public string Fullname { get; set; } = "Elton";
        public string Email { get; set; } = "@gmail.com";
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set 
            {
                if (PasswordChecker(value))
                {
                    password = value;
                }
                else password = "error";
            }
        }
        public bool PasswordChecker(string password)
        {
            bool upperChecker = false;
            bool lowerChecker = false;
            bool digitChecker = false;


            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    upperChecker = true;
                }
                if (char.IsLower(password[i]))
                {
                    lowerChecker = true;
                }
                if (char.IsDigit(password[i]))
                {
                    digitChecker = true;
                }
                if (password.Length >= 8 && upperChecker && lowerChecker && digitChecker)
                {
                    return true;
                }
            }
              return false;
        }

        public string ShowInfo()
        {
            return $"{Id} {Fullname} {Email} {Password}";
        }
    }
}
