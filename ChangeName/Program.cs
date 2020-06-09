using System;

namespace ChangeName
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new ConsoleNotification(); //instance of ConsoleNotification class and pass it to the constructor of the user class. this is dependency injection. 
            //we inject an instance of the ConsoleNotification class as a notificationService to the user class. 
            var user1 = new User("Jose", notificationService);
            user1.ChangeUsername("Jules"); 

        }
    }
}


//Dependency Inversion principle(DIP), high lvl modules should not depend on low level modules 
//both should depend on abstractions 
//Abstractions should not depend on details
//details should depend on abstractions 


//the user class and the consolenotification class both depend on the InotificationService interface.  