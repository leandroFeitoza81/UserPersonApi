using System;

namespace UserPersonApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string email { get; set; }
        public Endereco Endereco { get; set; }

    }
}
