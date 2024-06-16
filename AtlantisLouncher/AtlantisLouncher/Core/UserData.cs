using System;
namespace AtlantisLouncher.Core
{
    public class UserData
    {
        public UserData() { }

        public String statusCode { get; set; }

        public Guid Uid { get; set; }

        public User User { get; set; }

        public UserData(string StatusCode, Guid uid, User user)
        {
            statusCode = StatusCode;
            Uid = uid;
            User = user;
        }
    }
}
