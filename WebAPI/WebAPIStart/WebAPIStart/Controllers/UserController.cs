using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIStart.Models;

namespace WebAPIStart.Controllers
{
    public class UserController : ApiController
    {
        List<User> userList = new List<User>();
        public UserController()
        {
            userList.Add(new User { UserId = 1, Name = "Rakin", Address = "Dhaka" });
            userList.Add(new User { UserId = 2, Name = "Minhaz", Address = "Feni" });
        }
        //api/user
        public IHttpActionResult GetUsers()
        {
            return Ok(userList);
        }
        //api/user/1
        public IHttpActionResult GetUser(int id)
        {
            User user = userList.Find(u => u.UserId == id);
            return Ok(user);
        }
    }
}
