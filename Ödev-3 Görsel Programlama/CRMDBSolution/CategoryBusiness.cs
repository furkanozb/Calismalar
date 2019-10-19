using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDBSolution
{
    public class CategoryBusiness : DatabaseBusiness<Category>
    {
        CRMDBEntities db = new CRMDBEntities();
        public override void Create(Category t)
        {
            db.Category.Add(t);
            db.SaveChanges(); 
        }
        public override void Delete(int id)
        {
            Category cat = db.Category.Find(id);
            db.Category.Remove(cat);
            db.SaveChanges();
        }

        public override void Delete(Category t)
        {
            db.Category.Remove(t);
            db.SaveChanges();
        }

        public override List<Category> List()
        {
            return db.Category.ToList();
        }
        public override Category Read(int id)
        {
            return db.Category.SingleOrDefault(c => c.CategoryId == id);
        }

        public override void Update(Category t)
        {
            db.Category.Attach(t);
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
