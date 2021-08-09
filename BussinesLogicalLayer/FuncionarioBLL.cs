using DataAccessLayer;
using Entites;
using Entites.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicalLayer
{
    public class FuncionarioBLL : StandartBase<Funcionario>, IFuncionarioService
    {
        private FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        public bool Logar(string email, string senha)
        {
            return funcionarioDAL.Logar(email, senha);
        }
        public Response Delete(string cpf)
        {
            return funcionarioDAL.Delete(cpf);
        }

        public DataResponse<Funcionario> GetAll()
        {
            return funcionarioDAL.GetAll();
        }

        public Response Insert(Funcionario p)
        {
            Response response = this.Validate(p);
            if (!response.Success)
            {
                return response;
            }

            return funcionarioDAL.Insert(p);
        }

        public Response Update(Funcionario p)
        {
            Response response = this.Validate(p);
            if (!response.Success)
            {
                return response;
            }

            return funcionarioDAL.Update(p);
        }

    }
}
