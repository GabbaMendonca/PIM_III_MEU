namespace Camada.DTO
{
    public class Endereco
    {
        private string logradouro;
        private int numero;
        private string complemento;
        private string bairro;
        private int cep;
        private string municipio;
        private string cidade;

        public string Logradoura { get => logradouro; set => logradouro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public int Cep { get => cep; set => cep = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Cidade { get => cidade; set => cidade = value; }
    }
}