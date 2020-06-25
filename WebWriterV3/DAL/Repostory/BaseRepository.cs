using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebWriterV3.DAL.DbModel;

namespace WebWriterV3.DAL.Repostory
{
    public class BaseRepository<T> where T : BaseModel, new()
    {
        private WebWriterContext Db { get; set; }
        protected DbSet<T> Entity { get; set; }

        public BaseRepository(WebWriterContext db)
        {
            Db = db;
            Entity = Db.Set<T>();
        }

        public virtual bool Exist(T baseModel)
        {
            if (baseModel.Id > 0)
            {
                return false;
            }

            return Entity.Any(x => x.Id == baseModel.Id);
        }

        public virtual T Save(T model)
        {
            return Save(model, true);
        }

        public virtual List<T> Save(List<T> baseModels)
        {
            var list = baseModels.Select(x => Save(x, false)).ToList();
            Db.SaveChanges();
            return list;
        }

        private T Save(T model, bool saveImmediately)
        {
            if (model.Id > 0)
            {
                if (Db.Entry(model).State == EntityState.Detached)
                {
                    Entity.Attach(model);
                }
                Db.Entry(model).State = EntityState.Modified;
                Db.SaveChanges();
                return model;
            }

            Entity.Add(model);
            if (saveImmediately)
            {
                Db.SaveChanges();
            }

            return model;
        }

        //Try to not save it, count of records could be to much
        public virtual List<T> GetAll()
        {
            return Entity.ToList();
        }

        public virtual T Get(long id)
        {
            return Entity.FirstOrDefault(x => x.Id == id);
        }

        public virtual List<T> GetList(IEnumerable<long> ids)
        {
            return Entity.Where(x => ids.Contains(x.Id)).ToList();
        }

        public virtual void Remove(long id)
        {
            var model = new T()
            {
                Id = id
            };

            Remove(model);
        }

        public virtual void Remove(T baseModel)
        {
            if (baseModel == null)
            {
                throw new Exception("You try to remove null");
            }

            Entity.Remove(baseModel);
            Db.SaveChanges();
        }

        public virtual void Remove(IEnumerable<T> models)
        {
            var copyList = models.ToList();
            foreach (var model in copyList)
            {
                Remove(model);
            }
        }
    }
}
