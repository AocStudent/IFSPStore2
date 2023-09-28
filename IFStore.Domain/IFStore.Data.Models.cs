using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IFStore.Domain
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }

        public Cidade(int id, string nome, string estado)
        {
            this.Id = id;
            this.Nome = nome;
            this.Estado = estado;
        }
    }
}

namespace IFStore.Domain
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Cidade Cidade { get; set; }

        public Usuario(int id, string nome, string email, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Cidade = new Cidade(1, "São Paulo", "SP");
        }
    }
}