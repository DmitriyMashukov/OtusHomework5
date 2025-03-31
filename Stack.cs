using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomework5
{
    public class Stack
    {
        private StackItem _top;

        private class StackItem
        {
            public string Value { get; }
            public StackItem Previous { get; }

            public StackItem(string value, StackItem previous)
            {
                Value = value;
                Previous = previous;
            }
        }

        public Stack(params string[] str)
        {
            foreach (string s in str) 
                Add(s);
        }

        public void Add(string str)
        {
            _top = new StackItem(str, _top);
        }

        public string Pop()
        {
            if (_top == null)
                throw new ArgumentException("Стек пустой");

            string value = _top.Value;
            _top = _top.Previous;
            return value;
        }

        public int Size
        {
            get 
            {
                int count = 0;
                StackItem current = _top;
                while (current != null)
                {
                    count++;
                    current = current.Previous;
                }
                return count;
            }
        }

        public string Top
        {
            get { return _top?.Value;}
        }

        public static Stack Concat(params Stack[] stacks)
        {
            var reversedStack = new Stack();

            foreach (var s in stacks)
            {
                while (s.Size > 0)
                    reversedStack.Add(s.Pop());
            }
            return reversedStack;
        }
    }
}
