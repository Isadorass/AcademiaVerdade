using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Interfaces
{
    public interface IProfessoresService
    {
        Response Insert(Professores p);
        Response Update(Professores p);
        Response Delete(int id);
        DataResponse<Professores> GetAll();
    }
}
