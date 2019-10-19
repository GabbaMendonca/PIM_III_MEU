using System;
using Camada.DAL.DAO;
using Camada.DAL.Interfaces;

namespace Camada.DAL
{
    public class DAOFactory
    {
        public static FuncionarioDAO CriarFuncionarioDAO()
        {
            // return ProdutoDAOMemoria.Instancia();
            return new FuncionarioDAO();       
            
        }

        internal static IVeiculo CriarVeiculoDAO()
        {
            return new VeiculoDAO();
        }

        public static IMotorista CriarMotoristaDAO()
        {
            return new MotoristaDAO();
        }

        public static IEmpresa CriarEmpresaDAO()
        {
            return new EmpresaDAO();
        }

    }
}