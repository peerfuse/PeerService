using System;
namespace AtlantisLouncher.Core
{
    public class UserData
    {
        public UserData() { }

        public String statusCode { get; set; }

        public string uid { get; set; }

        public User user { get; set; }

        public UserData(string statusCode, string uid, User user)
        {
            this.statusCode = statusCode;
            this.uid = uid;
            this.user = user;
        }
    }
}
