using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeName
{
    interface INotificationService
    {
        void NotifyUsernameChanged(User user); // only method in this interface is the NotifyUsernameChange method, accepting a user object as its argument. 
    }
}
