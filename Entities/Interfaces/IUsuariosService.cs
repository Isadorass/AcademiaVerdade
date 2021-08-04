using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Interfaces
{
    public interface IUsuariosService
    {
        Response Insert(Usuarios u);
        Response Update(Usuarios u);
        Response Delete(int id);

        DataResponse<Usuarios> GetAll();
    }
}
