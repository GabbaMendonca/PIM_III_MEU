using System.Data;
using Camada.DAL;
using Camada.DAL.Interfaces;
using Camada.DTO.Veiculos;

namespace Camada.BLL.Controller
{
    public class VeiculoController
    {
        private IVeiculo dao;

        public VeiculoController()
        {
            dao = DAOFactory.CriarVeiculoDAO();
        }

        public bool Inserir(Veiculo v)
        {
            return dao.Inserir(v);
        }

        public DataSet Listar()
        {
            return dao.Listar();
        }

        public bool Atualizar(Veiculo v)
        {
            return dao.Atualizar(v);
        }

        public bool Excluir(int codigo)
        {
            return dao.Excluir(codigo);
        }
    }
}