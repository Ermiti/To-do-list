using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_list.IRepository
{
  public  interface IToDoList
    {
        List<LIstComponent> AllList();
        bool Delete(LIstComponent lIst);
        bool Delete(int Number);
        bool Add(LIstComponent lIst);
        bool Edid(LIstComponent lIst);

    }
}
