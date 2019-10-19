using System.Data;
using Camada.DTO.Veiculos;

namespace Camada.DAL.Interfaces
{
    public interface IVeiculo
    {
        bool Inserir(Veiculo v);

        DataSet Listar();

        bool Atualizar(Veiculo v);

        bool Excluir(int codigo);
    }
}