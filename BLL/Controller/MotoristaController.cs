using System.Data;
using Camada.DAL;
using Camada.DAL.Interfaces;
using Camada.DTO.Pessoas;

namespace Camada.BLL.Controller
{
    public class MotoristaController
    {
        private IMotorista dao;

        public MotoristaController()
        {
            dao = DAOFactory.CriarMotoristaDAO();
        }

        public bool Inserir(Motorista m)
        {
            return dao.Inserir(m);
        }

        public DataSet Listar()
        {
            return dao.Listar();
        }

        public bool Atualizar(Motorista m)
        {
            return dao.Atualizar(m);
        }

        public bool Excluir(int codigo)
        {
            return dao.Excluir(codigo);
        }
    }
}