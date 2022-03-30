using System;
using System.Collections.Generic;
using System.Text;

namespace Guess_Data_Structure_LL
{
    class Node<LL>
    {
         LL data;
        Node<LL> next;
        public Node(LL data)
        {
            this.data = data;
            next = null;
        }
        public LL Data
        {
            get { return data; }
            set { data = value; }


        }
        public Node<LL> Next
        {
            get { return next; }
            set { next = value; }

        }

    }
}
