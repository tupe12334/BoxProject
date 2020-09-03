using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicStandart
{
    public class Node<T> where T : IComparable<T>
    {
        #region props
        public Node<T> RNode { get; set; }
        public Node<T> LNode { get; set; }
        public T Data { get; set; }
        #endregion
        #region ctor
        public Node(T da)
        {
            Data = da;
        }
        #endregion
        #region functions
        public void Insert(T data)
        {
            if (data.CompareTo(Data)==0)
            {
                return;
            }
            if (data.CompareTo(Data) >= 1)
            {
                if (RNode == null)
                {
                    RNode = new Node<T>(data);
                }
                else
                {
                    RNode.Insert(data);
                }
            }
            else
            {
                if (LNode == null)
                {
                    LNode = new Node<T>(data);
                }
                else
                {
                    LNode.Insert(data);
                }
            }

        }
        public void RunLeftToRight(List<string> theList)
        {
            if (LNode != null) LNode.RunLeftToRight(theList);
            theList.Add(Data.ToString());
            Console.WriteLine(Data + " ");
            if (RNode != null)
            {
                RNode.RunLeftToRight(theList);
            }
        }
        #endregion
    }
}
