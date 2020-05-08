using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ymagi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Cpf { get; set; }     
        public int Telefone { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string nome, string email, string senha, int cpf, int telefone)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
