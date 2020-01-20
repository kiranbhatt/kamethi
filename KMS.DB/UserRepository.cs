using KMS.DB.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.DB
{
  public  class UserRepository : BaseDbRepository
    {
        readonly KMSDbContext _dbContext;

        public UserRepository(string connectionString) : base(connectionString)
        {
            _dbContext = new KMSDbContext();
        }

        public List<User> GetUsers()
        {
            List<User> users = _dbContext.Users.ToList();
            return users;
        }
        public User GetUser(int userId)
        {
            User user = _dbContext.Users.Where(x => x.UserId == userId).FirstOrDefault();

            return user;
        }
    }
}
