using System;
namespace AtlantisLouncher.Core
{
    public class UserData
    {
        public UserData() { }

        public string mail { get; set; }
        public string password { get; set; }

        public UserData(string _mail, string _password)
        {
            this.mail = _mail;
            this.password = _password;
        }
    }
}
