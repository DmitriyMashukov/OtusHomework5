using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomework5
{
    public static class StackExtensions
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            List<string> reversedList = new List<string>(); 

            while (s2.Size > 0)
                reversedList.Add(s2.Pop()); 

            foreach (var item in reversedList) 
                s1.Add(item);
        }
    }
}
