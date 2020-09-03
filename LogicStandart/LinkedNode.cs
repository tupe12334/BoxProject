using System;
using System.Collections.Generic;
using System.Text;

namespace LogicStandart
{
    public class LinkedNode<T>
    {
        //value of node
        public T value;
        //ref of next value
        public LinkedNode<T> next;
        //the previous value on the list
        public LinkedNode<T> previous;
        //ctor
        public LinkedNode(T value)
        {
            //saves value
            this.value = value;
        }
        public LinkedNode()
        {

        }
    }
}
