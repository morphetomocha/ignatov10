using System;
using System.Collections.Generic;
using System.Text;

namespace ignatov10
{
    public class ObobClass<T> where T : class
    {
        private readonly List<T> list = new List<T>();

        public T Get(int id)
        {
            if(id <= list.Count)
                return list[id];

            return null;
        }

        public void Add(T thing)
        {
            list.Add(thing);
        }

        public void Remove(int id)
        {
            if (id >= list.Count)
                return;

            list.RemoveAt(id);
        }

        public bool Contains(T element)
        {
            return list.Contains(element);
        }
    }
}
