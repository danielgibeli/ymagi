using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;



namespace Ymagi.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public Login()
        {
        }

        public Login(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
