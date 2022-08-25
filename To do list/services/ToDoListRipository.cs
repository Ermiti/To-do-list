using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_list.IRepository;
using System.Data.Entity;
using To_do_list.context;

namespace To_do_list.services
{
    public class ToDoListRipository : IToDoList
    {
        private UnitOfWork db;
        private unitOfWork db1;

        public ToDoListRipository(UnitOfWork context)
        {
            db = context;
        }

        public ToDoListRipository(unitOfWork db1)
        {
            this.db1 = db1;
        }

        public bool Add(LIstComponent lIst)
        {
            try
            {
                db1.LIstComponents.Add(lIst);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LIstComponent> AllList()
        {
            return db.IToDoList.AllList();
                
        }

        public bool Delete(LIstComponent lIst)
        {
            try
            {
                db1.LIstComponents.Remove(lIst);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int Number)
        {
            throw new NotImplementedException();
        }

        //public bool Delete(int Number)
        //{
        //    try
        //    {
        //        var V = db1.IToDoList.LIstComponents.Find(Number);
        //        db.LIstComponents.Remove(V);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public bool Edid(LIstComponent lIst)
        {
            try
            {

                var local = db1.Set<LIstComponent>()
                         .Local
                         .FirstOrDefault(f => f.Number == lIst.Number);
                if (local != null)
                {
                    db1.Entry(local).State = EntityState.Detached;
                }
                db1.Entry(lIst).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
