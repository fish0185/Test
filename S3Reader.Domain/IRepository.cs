using System;

namespace S3Reader.Domain
{
    public interface IRepository<T> where T : class
    {
        T Get();

        void Add(T t);

        void Delete(T t);
    }
}
