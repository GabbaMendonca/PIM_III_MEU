namespace Camada.DTO.Pessoas
{
    public class Funcionario : Pessoa
    {
        private Perfil perfil;

        public Funcionario()
        {
            this.perfil = new Perfil();
        }

        public Perfil Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
    }
}