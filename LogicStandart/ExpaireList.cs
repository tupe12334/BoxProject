using System;
using System.Collections.Generic;
using System.Text;

namespace LogicStandart
{
   public  class ExpaireList
    {
        public linked_list<Box> ExpaireLinkedList { get; set; }
        public ExpaireList()
        {
            ExpaireLinkedList = new linked_list<Box>();
        }
    }
}
