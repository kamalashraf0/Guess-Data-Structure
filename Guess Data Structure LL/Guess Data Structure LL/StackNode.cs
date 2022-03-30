using System;
using System.Collections.Generic;
using System.Text;

namespace Guess_Data_Structure_LL
{
    class NodeS<T>
    {
        T data;
        NodeS<T> next;
        public NodeS(T v,NodeS<T> n )
        {
            data = v;
            next = n;
        }
        public T Data
        {
            get
            {
                return data;
            }
        }
        public NodeS<T> Next
        {
            get
            {
                return next;
            }
        }
    }
}
