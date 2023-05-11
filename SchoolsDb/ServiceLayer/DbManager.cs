using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ServiceLayer
{
    public class DbManager<T, K>
    {
        IDb<T, K> context;

        public DbManager(IDb<T, K> context)
        {
            this.context = context;
        }

        public void Create(T item)
        {
            context.Create(item);
        }

        public T Read(K key, bool useNavigationalProperties = false)
        {
            return context.Read(key, useNavigationalProperties);
        }

        public IEnumerable<T> ReadAll(bool useNavigationalProperties = false)
        {
            return context.ReadAll(useNavigationalProperties);
        }

        public void Update(T item, bool useNavigationalProperties = false)
        {
            context.Update(item, useNavigationalProperties);
        }

        public void Delete(K key)
        {
            context.Delete(key);
        }
    }
}
