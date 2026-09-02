using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID>
    {
        bool Create(CLASS obj);
        List<CLASS> Get();
        CLASS Get(ID id);
        bool Delete(ID id);
        bool Update(CLASS obj);
        
    }
}
