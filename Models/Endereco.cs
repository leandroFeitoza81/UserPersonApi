namespace UserPersonApi.Models
{
    public class Endereco
    {
        public int Id { get; set; }
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
