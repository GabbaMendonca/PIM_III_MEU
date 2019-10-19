using System.Data;
using Camada.DTO.Pessoas;

namespace Camada.DAL.Interfaces
{
    public interface IMotorista
    {
        bool Inserir(Motorista m);

        DataSet Listar();

        bool Atualizar(Motorista m);

        bool Excluir(int codigo);
    }
}