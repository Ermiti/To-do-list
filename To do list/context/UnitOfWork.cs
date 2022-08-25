using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_list.IRepository;
using To_do_list.services;


namespace To_do_list.context
{
  
    public class UnitOfWork : IDisposable
    {
        To_do_list.unitOfWork db = new To_do_list.unitOfWork();

        private IToDoList _IToDoList;
        public IToDoList IToDoList
        {
            get
            {
                if (_IToDoList == null)
                {
                    _IToDoList = new ToDoListRipository(db);
                }
                return _IToDoList;
            }
        }
        public void Save()
        {
            
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
        
    }
}
