using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posled
{
    public class Node<T>
    {
        public Node(T znach)
        {
            Znach = znach;
        }
        public T Znach { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
    }

    public class Posled<T>
    {
        Node<T> first;
        Node<T> last;
        int count;

        public void pushBack(T znach)
        {
            Node<T> node = new Node<T>(znach);
            Node<T> temp = last;
            last = node;
            if (count == 0)
                first = last;
            else
            {
                temp.Next = last;
                last.Prev = temp;
            }
            count++;
        }

        public void pushFront(T znach)
        {
            Node<T> node = new Node<T>(znach);
            Node<T> temp = first;
            first = node;
            if (count == 0)
                last = first;
            else
            {
                temp.Prev = first;
                first.Next = temp;
            }
            count++;
        }

        public T popFront()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = first.Znach;
            first = first.Next;
            count--;
            return output;
        }
        public T popBack()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = last.Znach;
            last = last.Prev;
            count--;
            return output;
        }

        public T front()
        {
            if (count != 0)
            {
                return first.Znach;
            }
            else
                throw new InvalidOperationException();
        }

        public T back()
        {
            if (count != 0)
            {
                return last.Znach;
            }
            else
                throw new InvalidOperationException();
        }

        public int size()
        {
            return count;
        }

        public void clear()
        {
            count = 0;
        }

        public T[] toArray()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T[] output = new T[count];
            Node<T> temp = first;
            for (int i = 0; i < count; i++)
            {
                output[i] = temp.Znach;
                temp = temp.Next;
            }
            return output;
        }
    }
}
