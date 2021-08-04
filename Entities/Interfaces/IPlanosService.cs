using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Interfaces
{
   public interface IPlanosService
   {
        Response Insert(Planos p);
        Response Update(Planos p);
        Response Delete(int id);

        DataResponse<Planos> GetAll();
   }
}
