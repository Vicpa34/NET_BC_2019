﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    class UserList
    {
        private List<UserProfile> users = new List<UserProfile>();

        public void Add(string fullName, UserProfile.Genders gender, DateTime date)   //function to add new users lietotajus
        {
            //parbaudes
            //1. Date cannot be in the future
            //2. Date cant be less than 01.01.1800
            //3. Full name cannot exceed 20 symbols

            //
            UserProfile user = new UserProfile(fullName, gender, date);
            users.Add(user);

        }

    }
}