﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNum;

        public Contestant()
        {

        }

        public void GetContestantInfo()
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            email = UserInterface.GetEmail();
            registrationNum = UserInterface.GetRegistrationNumber();
        }


    }
    
   

}
