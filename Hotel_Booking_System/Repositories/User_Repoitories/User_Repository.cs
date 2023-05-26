using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Repositories.User_Repoitories
{
    public class User_Repository
    {
        private readonly HotelContext _UserContext;
        public User_Repository(HotelContext context)
        {
            _UserContext = context;
        }
        //GetAllUsers
        public IEnumerable<User> GetAllUser()
        {
            return _UserContext.Users.ToList();
        }
        //GetUserById
        public User GetUserById(int User_Id)
        {
            return _UserContext.Users.FirstOrDefault(x => x.User_Id == User_Id);
        }
        //PostUser
        public User PostUser(User user)
        {
            var v_User = _UserContext.Users;
            _UserContext.Add(user);
            _UserContext.SaveChanges();
            return user;
        }
        //PutUser
        public User PutUser(int id, User user)
        {
            var v_User = _UserContext.Users;
            _UserContext.Entry(user).State = EntityState.Modified;
            _UserContext.SaveChangesAsync();
            return user;
        }
        //DeleteUser
        public User DeleteUser(int id)
        {
            var v_User = _UserContext.Users.Find(id);
            _UserContext.Users.Remove(v_User);
            _UserContext.SaveChanges();
            return v_User;
        }
    }
}

