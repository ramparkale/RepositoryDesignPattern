
using RepositoryDesignPattern.Models;
using System.Formats.Tar;

namespace RepositoryDesignPattern.Services
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
        RepositoryDbContext db;

        public Repository(RepositoryDbContext db)
        {
            this.db = db;
        }
        public void Add(Tentity entity)
        {
            db.Set<Tentity>().Add(entity);
            db.SaveChanges();
           // throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Tentity entity=GetById(id);
            db.Set<Tentity>().Remove(entity);
            db.SaveChanges();
            //throw new NotImplementedException();
        }

        public List<Tentity> GetAll()
        {
            return db.Set<Tentity>().ToList();
            //throw new NotImplementedException();
        }

        public Tentity GetById(int id)
        {
            return db.Set<Tentity>().Find(id);
            //throw new NotImplementedException();
        }

        public void Update(Tentity entity)
        {
            db.Set<Tentity>().Update(entity);
            db.SaveChanges();           
            //throw new NotImplementedException();
        }
    }
}
