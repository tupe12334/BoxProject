using System;
using System.Collections.Generic;
using System.Text;

namespace LogicStandart
{

    public class linked_list<T>
    {
        public LinkedNode<T> _start { get; set; }//the start of the list
        public LinkedNode<T> _end { get; set; }//the end of the list
                                               //get the value in the index of index
        #region Methode
        public bool GetAt(int index, out LinkedNode<T> valuAt)
        {
            //tmp value start it with tmp
            LinkedNode<T> tmp = _start;
            //a loop in the size of the index
            for (int i = 0; i < index && tmp != null; i++)
            {
                //move to the next node in the list
                tmp = tmp.next;
            }
            //save defoult value of T
            valuAt = default(LinkedNode<T>);
            //if tmp is null return false that means that the index is out of the list
            if (tmp == null) return false;
            //save the value of the node in the index
            valuAt = tmp;
            //return that we found the index
            return true;
        }
        internal void AddFirst(LinkedNode<T> n)
        {
            //save the next of n as _start
            n.next = _start;
            //if end is null that means that the first value is allsow the last so save the first n as end
            if (_end == null) _end = n;
            //if _start isnt null the previous of start is n
            if (_start != null) _start.previous = n;
            //save the new node=n as _start
            _start = n;
        }
        internal void AddFirst(ref LinkedNode<T> n)
        {
            n.next = _start;//save the next of n as _start
            if (_end == null) _end = n;//if end is null that means that the first value is allsow the last so save the first n as end
            if (_start != null) _start.previous = n;//if _start isnt null the previous of start is n
            _start = n;//save the new node=n as _start
        }
        //add a number to the beginning of the list
        public void AddFirst(T value)
        {
            //create new nude with the value we got
            LinkedNode<T> n = new LinkedNode<T>(value);
            AddFirst(n);
        }
        //add the last number of the list
        internal void AddLast(ref LinkedNode<T> n)
        {
            //if there is no node in the list
            if (_start == null)
            {
                //when you add the last nude you could allsow add the first node there the same
                AddFirst(n);
                //finish the methode
                return;
            }
            //save the next of end as the new node
            _end.next = n;
            //save the previous of end as _end
            n.previous = _end;
            //save the node as end
            _end = n;
        }
        //methode that removes itemthat could be not first and not last
        //gets the node to remove
        internal bool RemoveItem(LinkedNode<T> itemToRemove)
        {
            //if no item exist
            if (_start == null || _end == null) return false;
            else if (itemToRemove.previous == null && itemToRemove.next == null)
            {
                _end = _start = null;
            }
            //if previous is null means first item
            else if (itemToRemove.previous == null)
            {
                _start = _start.next;
                _start.previous = null;
            }
            //if next is null means last item
            else if (itemToRemove.next == null)
            {
                _end = _end.previous;
                _end.next = null;
            }
            //if item is in the middle
            else
            {
                //turn the connection to point each other and not the item between them
                itemToRemove.next.previous = itemToRemove.previous;
                itemToRemove.previous.next = itemToRemove.next;
            }
            return true;
        }
        //add the last number of the list
        public void AddLast(T value)
        {
            //create new node with the value of the value
            LinkedNode<T> n = new LinkedNode<T>(value);
            AddLast(ref n);
        }
        //remove the first value
        public bool RemoveFirstValue(out T valueWeRemoved)
        {
            //save the value of valueWeRemoved as his defoult
            valueWeRemoved = default(T);
            //if you cant remove a number return false=that means you cant remove the value because it dosnt exist
            if (_start == null) return false;
            //save the value we remove
            valueWeRemoved = _start.value;
            //turn the _start of the list to the next  number on the list
            _start = _start.next;
            //if the value exist turn  the value that is befor our value to null
            if (_start != null) _start.previous = null;
            //if the start dosnt exist that means there is no more last so i want to turn end to null
            if (_start == null) _end = null;
            //return that we removed first value
            return true;
        }
        public bool RemoveLast(out T valueToRemove)
        {
            //if the start and end are the same it means if we move the first is the same as moving the last
            if (_end == _start) return RemoveFirstValue(out valueToRemove);
            //so we use the remove first value
            //save the value of want to remove
            valueToRemove = _end.value;
            //turn end to the end befor him
            _end = _end.previous;
            //turn the next value to null
            _end.next = null;
            //return that the ramove methode wroked
            return true;
        }
        //create the to string of linked_list
        public override string ToString()
        {
            //create a string builder
            StringBuilder sb = new StringBuilder();
            //create tmp node and start it with _start
            LinkedNode<T> tmp = _start;
            //if tmp exist do a loop untill it stops to exist
            while (tmp != null)
            {
                //add value to our string builder
                sb.AppendLine($"{tmp.value.ToString()}, ");
                //turn tmp to the next value on the list
                tmp = tmp.next;
            }
            //return the string we got
            return sb.ToString();
        }
        public List<T> TurnLinkedListToList()
        {
            //create list
            List<T> list = new List<T>();
            //create tmp node on linled list
            LinkedNode<T> tmp = _start;
            //if tmp exist do a loop untill it stops to exist
            while (tmp != null)
            {
                list.Add(tmp.value);
                //turn tmp to the next value on the list
                tmp = tmp.next;
            }
            //return list
            return list;
        }
        #endregion
    }
}
