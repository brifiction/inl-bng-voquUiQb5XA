using System.Collections.Generic;

namespace InlogikConsoleApp.Infrastructure.Interfaces
{
    public interface IRepository<TKey, TValue> where TKey : notnull
    {
        TValue? Get(TKey key);
        void Add(TKey key, TValue value);
        bool ContainsKey(TKey key);
        Dictionary<TKey, TValue> GetAll();
    }
} 