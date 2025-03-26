using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomework5
{
    internal class Stack
    {
        private List<string> _storage;

        public Stack(params string[] str)
        {
            _storage = new List<string>(str);
        }

        public void Add(string str)
        {
            _storage.Add(str);
        }

        public string Pop()
        {
            if (_storage.Count == 0)
                throw new ArgumentException("Стек пустой");

            int lastIndex = _storage.Count - 1;
            string element = _storage[lastIndex];
            _storage.RemoveAt(lastIndex);
            return element;
        }

        public int Size
        {
            get { return _storage.Count; }
        }

        public string Top
        {
            get
            {
                if (_storage.Count == 0)
                    return null;

                return _storage[_storage.Count - 1];
            }
        }
    }
}
