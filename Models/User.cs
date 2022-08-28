using System;

namespace UserPersonApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
    }
}
