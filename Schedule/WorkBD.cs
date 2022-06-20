using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    class WorkBD
    {
        public bool UserHave(string login)
        {
            PersonContext context = new PersonContext();
            if (context.Users.Any(o => o.Login == login))
            {
                return true;
            }
            else return false;
        }
        public bool UserHave(string login, string pass)
        {
            PersonContext context = new PersonContext();
            if (context.Users.Any(o => o.Login == login) && context.Users.Any(o => o.Password == pass))
            {
                return true;
            }
            else return false;
        }
        public bool IsAdmin(string login)
        {
            PersonContext context = new PersonContext();
            if (context.Users.Any(o => o.Permis == 1 && o.Login == login))
            {
                return true;
            }
            else return false;
        }
        public class PersonContext : DbContext
        {
            public PersonContext() : base("Database1Entities")
            {

            }
            public DbSet<Logins> Users { get; set; }
        }

    }
}
