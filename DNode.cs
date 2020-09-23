using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLInkedListJMC
{
    public class DNode<E>
    {
        private DNode<E> prev;
        private E element;
        private DNode<E> next;

        public DNode(DNode<E> prev, E element, DNode<E> next)
        {
            this.prev = prev;
            this.element = element;
            this.next = next;
        }

        public DNode<E> Prev { get => prev; set => prev = value; }
        public E Element { get => element; set => element = value; }
        public DNode<E> Next { get => next; set => next = value; }
    }
}
