using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID,RETURN>
    {
        CLASS Get(ID id);
        List<CLASS> Get();
        RETURN Add(CLASS obj);
        bool Delete(ID id);
        bool Update(CLASS obj);
    }
}
