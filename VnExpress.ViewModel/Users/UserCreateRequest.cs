﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VnExpress.ViewModel.Users
{
    public class UserCreateRequest
    {
        public int IdUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
