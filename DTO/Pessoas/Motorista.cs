namespace Camada.DTO.Pessoas
{
    public class Motorista : Pessoa
    {
        private string chn;
        private Empresa empresa;
    
        public Motorista()
        {
            this.chn = string.Empty;
        }

        public string Chn
        {
            get { return chn; }
            set { chn = value; }
        }

        public Empresa Empresa 
        {
            get { return empresa; }
            set { empresa = value; }
        }
    }
}