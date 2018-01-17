using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Repository<T> where T : class
    {
        public MyContext db = new MyContext();


        public Repository()
        {
            if (MyContext.db == null) MyContext.db = new MyContext();
        }


        public List<T> GetAll()
        {
            if (MyContext.db == null) MyContext.db = new MyContext();
            List<T> liste = db.Set<T>().ToList();
            return liste;

        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public T Find(Predicate<int> Condition)
        {
            return db.Set<T>().Find(Condition);

        }
        public void Insert(T newRecord)
        {

            db.Set<T>().Add(newRecord);
            db.SaveChanges();
        }
        public void Update(T obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var obj = db.Set<T>().Find(id);
            db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

    }
    }

