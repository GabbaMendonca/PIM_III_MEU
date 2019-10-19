using System.Collections.Generic;
using System.Data;
using Camada.DTO.Pessoas;

namespace Camada.DAL.Interfaces
{
    public interface IFuncionario
    {
        bool Inserir(Funcionario p);

        DataSet Listar();

        bool Atualizar(Funcionario p);

        bool Excluir(int codigo);
        List<string> ListarPerfil();
    }
}