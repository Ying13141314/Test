using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest
{
    public class Reservation
    {
        public User MadeBy { get; set; }
        public bool CanBeCancelledBy(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            return user.IsAdmin || user==MadeBy;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
