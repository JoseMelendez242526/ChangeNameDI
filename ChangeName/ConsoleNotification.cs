using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeName
{
    internal class ConsoleNotification:INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine("Username has been changed to: {0}", user.Username); 
        }
    }
}
