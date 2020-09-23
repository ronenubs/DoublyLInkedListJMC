using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLInkedListJMC
{
    public class DList<E>
    {
        private DNode<E> header, trailer;
        private int size;

        public DList()
        {
            header = new DNode<E>(null, default, null);
            trailer = new DNode<E>(header, default, null);
            header.Next = trailer;
            
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size <= 0;
        }

        public E First()
        {
            if (IsEmpty())
            {
                throw new EmptyListException("The list is empty.");
            }
            return header.Next.Element;
        }

        public E Last()
        {
            if (IsEmpty())
            {
                throw new EmptyListException("The list is empty.");
            }
            return trailer.Prev.Element;
        }

        public void AddFirst(E element)
        {
            AddBetween(header, element, header.Next);
        }

        public void AddLast(E element)
        {
            AddBetween(trailer.Prev, element, trailer);
        }

        private void AddBetween(DNode<E> prev, E element, DNode<E> next)
        {
            DNode<E> newNode = new DNode<E>(prev, element, next);
            prev.Next = newNode;
            next.Prev = newNode;
            size++;
        }

        private E Remove(DNode<E> node)
        {
            DNode<E> tempNext = node.Next;
            DNode<E> tempPrev = node.Prev;
            tempPrev.Next = tempNext;
            tempNext.Prev = tempPrev;
            E tempElement = node.Element;
            node.Next = null;
            node.Prev = null;
            size--;
            return tempElement;
        }

        public E RemoveFirst()
        {
            if(IsEmpty())
            {
                throw new EmptyListException("No nodes to be removed.");
            }
            return Remove(header.Next);
        }

        public E RemoveLast()
        {
            if (IsEmpty())
            {
                throw new EmptyListException("No nodes to be removed.");
            }
            return Remove(trailer.Prev);
        }
    }
}
