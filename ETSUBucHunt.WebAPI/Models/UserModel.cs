﻿namespace ETSUBucHunt.WebApp.Models
{
    public class User
    {
        //The User's email and phone numbers will be stored in these strings.
        public String UserEmailAddress { get; set; }
        public String UserPhoneNumber { get; set; }
        public String UserName { get; set; }

        //default constructor with default values
        public User()
        {
            UserName = "default";
            UserEmailAddress = "default ";
            UserPhoneNumber = "default";
        }


        //Normal constructor that the web page can call to pass through data that will be stored as new user.
        public User(String inputUserName, String inputEmailAddress, String inputPhoneNumber)
        {
            UserName = inputUserName;   
            UserEmailAddress = inputEmailAddress;
            UserPhoneNumber = inputPhoneNumber;
        } 
    }
}
