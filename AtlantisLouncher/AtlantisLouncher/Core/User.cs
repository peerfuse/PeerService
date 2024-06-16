using System;
namespace AtlantisLouncher.Core
{
    public class User
    {
        public User() { }
        public string mail { get; set; }
        public string pass { get; set; }

        public User(string mail, string pass)
        {
            this.mail = mail;
            this.pass = pass;
        }
    }
}
