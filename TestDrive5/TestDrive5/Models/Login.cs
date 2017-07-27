﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive5.Models
{
    public class Login
    {

        public string email { get; private set; }
        public string senha { get; private set; }

        public Login(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

    }
}
