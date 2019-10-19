using System.Data;
using Camada.DTO;

namespace Camada.DAL.Interfaces
{
    public interface IEmpresa
    {
        bool Inserir(Empresa e);

        DataSet Listar();

        bool Atualizar(Empresa e);

        bool Excluir(int codigo);
    }
}