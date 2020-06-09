using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeName
{
    class User  //User class depends on the Inotificationclass class 
    {
        private INotificationService _notificationService; //notification service field holds a reference for an object type Inotificationservice. 
        public User(string username,INotificationService notificationService) //constructor argument for the user class of type INotificationService
        {
            Username = username;
            _notificationService = notificationService; 
        }

        public string Username { get; set; }

        public void ChangeUsername(string newUsername)
        {
            Username = newUsername;
            _notificationService.NotifyUsernameChanged(this); //The this keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method
        }
       
    }
}
