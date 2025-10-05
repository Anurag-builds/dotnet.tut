using System.Collections;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------ArrayList--------");
            ArrayList al = [];
            al.Add(10);
            al.Add(20.5);
            al.Add("Hello");
            foreach (object o in al)
                Console.WriteLine(o);


            Console.WriteLine("--------Hashtable--------");
            Hashtable hs = [];
            hs.Add(101, "bum");
            hs.Add(102, 102);
            hs.Add(103, 10.3);
            foreach (DictionaryEntry d in hs)
                Console.WriteLine(d.Key + "->" + d.Value);

            Console.WriteLine("--------Stack(LIFO)--------");

            Stack st = [];
            st.Push(20);
            st.Push(10);
            st.Push("fucku");
            st.Push("5.55");

            Console.WriteLine(st.Pop() + " removes Last entry(LIFO)");
            Console.WriteLine(st.Peek() + " shows Last entry");

            Console.WriteLine("--------Queue(FIFO)--------");
            Queue q = [];
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            Console.WriteLine($"Removed {q.Dequeue()} , and next in queue is {q.Peek()}");

            Console.WriteLine("--------SortedList--------");

            SortedList sl = [];
            sl.Add(103, "Sita");
            sl.Add(105, "Ram");
            sl.Add(104, "Laxman");

            foreach (DictionaryEntry d in sl)
                Console.WriteLine(d.Key + " - " + d.Value);

        }
    }
}