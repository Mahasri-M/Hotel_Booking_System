using Hotel_Booking_System.Models;
using Hotel_Booking_System.Repositories.Room_Repositories;
using Hotel_Booking_System.Repositories.User_Repoitories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_Controller : ControllerBase
    {
        private readonly IUser user;
        public User_Controller(IUser user)
        {
            this.user = user;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return user.GetAllUser();
        }

        [HttpGet("{id}")]
        public User GetById(int id)
        {
            return user.GetUserById(id);
        }
        [HttpPost]
        public User PostUser(User User)
        {
            return user.PostUser(User);
        }
        [HttpPut("{id}")]
        public User PutUser(int id, User User)
        {
            return user.PutUser(id, User);
        }
        [HttpDelete("{id}")]
        public User DeleteUser(int id)
        {
            return user.DeleteUser(id);
        }
    }
}
