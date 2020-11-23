using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeManager
{
    // Future update
    public class ReminderInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Interval { get; set; }

    }

    public class UserInfo
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Sex Sex { get; set; }
        public List<ReminderInfo> ReminderInfos { get; set; }
    }

    public enum Sex
    {
        Male,
        Female
    };

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class DbContext : System.Data.Entity.DbContext
    {
        public virtual DbSet<User> Users { get; set; }
    }
}
