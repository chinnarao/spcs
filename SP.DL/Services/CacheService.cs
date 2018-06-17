using System;
using System.Collections.Generic;
using System.Text;

namespace SP.DL.Services
{
    public class CacheService : ICacheService
    {
        public bool Contains(string key)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public T Retrieve<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Store(string key, object data)
        {
            throw new NotImplementedException();
        }
    }

    public interface ICacheService
    {
        bool Contains(string key);

        T Retrieve<T>(string key);

        void Store(string key, object data);

        // For CacheAttribute parameter support use the following
        // void Store(string key, object data, IDictionary<string, object> parameters)

        void Remove(string key);
    }
}
