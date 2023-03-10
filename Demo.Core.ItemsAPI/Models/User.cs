namespace Demo.Core.ItemsAPI.Models
{
    public class User
    {
        public string UserName;

        public string Password;

        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}
