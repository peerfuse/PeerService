using System;
namespace AtlantisLouncher.Core
{
    public class User
    {
        public User()
        {
        }

        public string UserId { get; set; }

        public User(string userId)
        {
            UserId = userId;
        }
    }
}
