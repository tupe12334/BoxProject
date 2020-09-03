using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    public class Bst<T> where T : IComparable<T>
    {
        #region props
        Node<T> root;
        #endregion
        #region ctor
        public Bst()
        {

        }
        #endregion
        #region functions
        public void Insert(T data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new Node<T>(data);
            }
        }
        public void delete(T value)
        {
            #region setup
            Node<T> nowNode = root;
            Node<T> prevNode = root;
            bool isLeft = false; // true = left | false = rigth
            #endregion
            #region find
            if (nowNode == null) // root empty...
            {
                return;
            }
            while (nowNode != null && (nowNode.Data.CompareTo(value)) != 0)
            {
                prevNode = nowNode;
                if (value.CompareTo(nowNode.Data) < 0)
                {
                    nowNode = nowNode.LNode;
                    isLeft = true;
                }
                else
                {
                    nowNode = nowNode.RNode;
                    isLeft = false;
                }
            }
            if (nowNode == null) // value dont "real"
            {
                return;
            }
            #endregion
            #region have no child
            if (nowNode.RNode == null && nowNode.LNode == null)
            {
                if (nowNode == root)
                {
                    root = null;
                }
                else
                {
                    if (isLeft)
                    {
                        prevNode.LNode = null;
                    }
                    else
                    {
                        prevNode.RNode = null;
                    }
                }
            }
            #endregion
            #region have left chaild only
            else if (nowNode.RNode == null) // if he have object in left
            {
                if (nowNode == root)
                {
                    root = nowNode.LNode;
                }
                else
                {
                    if (isLeft)
                    {
                        prevNode.LNode = nowNode.LNode;
                    }
                    else
                    {
                        prevNode.RNode = nowNode.RNode;
                    }
                }
            }
            #endregion
            #region have righ chaild only
            else if (nowNode.LNode == null)
            {
                if (nowNode == root)
                {
                    root = nowNode.RNode;
                }
                else
                {
                    if (isLeft)
                    {
                        prevNode.LNode = nowNode.RNode;
                    }
                    else
                    {
                        prevNode.RNode = nowNode.RNode;
                    }
                }
            }
            #endregion
            #region have two chailds
            else
            {
                Node<T> chaild = getChaild(nowNode);
                if (nowNode == root)
                {
                    root = chaild;
                }
                else if (isLeft)
                {
                    prevNode.LNode = chaild;
                }
                else
                {
                    prevNode.RNode = chaild;
                }
            }
            #endregion

        }
        public Node<T> getChaild(Node<T> tempnode)
        {
            Node<T> prevOfNode = tempnode;
            Node<T> chaild = tempnode;
            Node<T> nowNode = tempnode;
            while (nowNode != null)
            {
                prevOfNode = chaild;
                chaild = nowNode;
                nowNode = nowNode.LNode;
            }
            if (chaild != tempnode.RNode)
            {
                prevOfNode.LNode = chaild.RNode;
                chaild.RNode = tempnode.RNode;
            }
            chaild.LNode = tempnode.LNode;
            return chaild;
        }
        public void RunLeftToRight()
        {
            if (root!=null)
            {
                root.RunLeftToRight();
            }
        }
        #endregion
    }
}
