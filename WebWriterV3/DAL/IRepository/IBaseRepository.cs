using System.Collections.Generic;
using WebWriterV3.DAL.DbModel;

namespace WebWriterV3.DAL.IRepository
{
    public interface IBaseRepository<T> where T : BaseModel, new() 
    {
        bool Exist(T baseModel);

        T Save(T model);

        List<T> Save(List<T> baseModels);

        //Try to not save it, count of records could be to much
        List<T> GetAll();

        T Get(long id);

        List<T> GetList(IEnumerable<long> ids);

        void Remove(long id);

        void Remove(T baseModel);

        void Remove(IEnumerable<T> models);
    }
}
