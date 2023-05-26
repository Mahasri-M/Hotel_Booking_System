using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Repositories.User_Repoitories
{
    public interface IUser
    {
        public IEnumerable<User> GetAllUser();
        public User GetUserById(int User_Id);
        public User PostUser(User user);
        public User PutUser(int id, User user);
        public User DeleteUser(int id);
    }
}
