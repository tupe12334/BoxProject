using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    class HeightNode<T> : Node<T> where T : IComparable<T>
    {
        public double Height { get; set; }
        public YBst<T> YBst { get; set; }
        public HeightNode(T da) : base(da)
        {
        }
    }
}
