using DataAccessLayer;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicalLayer
{
    public class FormaPagamentoBLL : StandartBase<FormaPagamento>, IFormaPagamentoService
    {
        private FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();

        public Response Delete(string id)
        {
            return formaPagamentoBLL.Delete(id);
        }

        public DataResponse<FormaPagamento> GetAll()
        {
            return formaPagamentoBLL.GetAll();
        }

        public Response Insert(FormaPagamento f)
        {

            Response response = this.Validate(f);
            if (!response.Success)
            {
                return response;
            }

            return formaPagamentoBLL.Insert(f);
        }

        public Response Update(FormaPagamento f)
        {
            Response response = this.Validate(f);
            if (!response.Success)
            {
                return response;
            }

            return formaPagamentoBLL.Update(f);
        }
    }
}
