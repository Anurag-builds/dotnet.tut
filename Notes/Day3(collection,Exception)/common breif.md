# Doc1 exception_pre_notes
complie time--syntax error
runtime -exception

exception is runtime error ,and when exception is generated then program execution is stopped,
we don't want to stop the program execution then we need to handle exception
when we handle the exception ,program execution is continued even after the exception

exception is handle by using try catch block
1.try-monitor an exception
2.catch-handle the exception which is thrown by try block

Exception is base class for all child exception
Exception class can handle all types of exception.

finally:finally is always executed even after the exception is present or not
```csharp
class Exception
{
	string msg;

	public Exception(string m)
	{
		msg=m;
	}

	public string Message
	{
		get
		{
			return msg;
		}
	}
}
```

# Doc2 exception_prog_pre

```csharp
namespace exceptiondemo_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;

                Console.WriteLine("Enter Number:");
                a = int.Parse(Console.ReadLine());
                b = 10 / a;
                Console.WriteLine("b:" + b);

                //int[] c = new int[5];
                //c[7] = 200;

                Console.WriteLine("------------before catch----------------");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("do not enter zero");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers");
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("array index is invalid");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("finally is always executed");
            }

            Console.WriteLine("------------after catch----------------");

            Console.ReadKey();
        }
    }
}
```


Exception demo 2
```csharp
namespace exceptiondemo2_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                a = 0;
                b = 10 / a;

                Console.WriteLine("b:" + b);
            }
            finally
            {
                Console.WriteLine("finally is always executed");
            }

            Console.ReadKey();

        }
    }
}
```

Exception Demo 3:
```csharp
//user defined exception
namespace exceptiondemo3_pre
{
    class PasswordLengthException : Exception
    {
        public PasswordLengthException() : base("Password length must be greater than or equal to 6")
        { }
    }
    class SpecialCharException: Exception
    {
        public SpecialCharException() : base("Password must contains atleast one special charecter")
        { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                string password;

                Console.WriteLine("Enter Password:");
                password = Console.ReadLine();

                if(password.Length<6)
                    throw new PasswordLengthException();

                if (!(password.Contains("@") || password.Contains("#") || password.Contains("$")))
                    throw new SpecialCharException();

                Console.WriteLine("Valid Password");
            }
            catch(PasswordLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SpecialCharException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
```


# Doc3 collection_notes_pre
array
1.fixed size
2.collection of similar types

collection
1.flexible size
2.collection of mixed types
3.type of collection is a object
4.boxing and unboxing is required to store and read the elements,so performance will reduce

object o=10; //boxing
int a=o;  //unboxing

Namespace:System.Collections

classes of System.Collections
1.ArrayList-index based
2.Hashtable-collection of key/value pair which is based on hashcode of the key
3.Stack-LIFO
4.Queue-FIFO
5.SortedList-collection of key/value pair ,which is sorted by keys

Generics
1.flexible size
2.collection of similar types.
3.no boxing and unboxing required, so performance will increase.

namespace:System.Collections.Generic

classes of System.Collections.Generic
1.List-index based
2.stack-LIFO
3.queue-FIFO
4.Dictionary-collection of key/value pair


# Doc 4 collection_prog_pre

Collection demo 1:
```csharp
using System.Collections;

namespace coldemo_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(10);
            al.Add(10.2);
            al.Add("ram");
            al.Add('r');
            al.Add(true);

            Console.WriteLine("\n---------------------using foreach loop---------------------");
            foreach (object o in al)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\n---------------------using for loop---------------------");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.WriteLine("\n---------------------using iterator---------------------");
            IEnumerator itr=al.GetEnumerator();
            while (itr.MoveNext())
            {
                Console.WriteLine(itr.Current);
            }

            Console.ReadKey();
        }
    }
}
```

Collection demo 2:
```csharp
using System.Collections;

namespace coldemo2_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();

            al.Add(30);
            al.Add(10);
            al.Add(50);
            al.Add(20);
            al.Add(40);

            // Console.WriteLine(al.Count);
            //Console.WriteLine(al.Contains(30));
            //  Console.WriteLine(al.IndexOf(30));

              //al.Insert(2,800);
               //al.Remove(30);
            // al.RemoveAt(2);
           // al.Reverse();
            al.Sort();


            foreach (object o in al)
            {
                Console.WriteLine(o);
            }

           Console.ReadKey();
        }
    }
}
```
Collection demo 3:
```csharp
using System.Collections;

namespace coldemo3_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(101, "ram");
            ht.Add(102, "avinash");
            ht.Add(103, "ganesh");
            ht.Add(104, "suman");
            ht.Add(105, "ganesh");
            // ht.Add(102, "rakesh");
            ht.Add(106,null);
            //ht.Add(null, "rahul");

            //foreach (object key in ht.Keys)
            //{
            //    object val= ht[key];
            //    Console.WriteLine(key + " " + val);
            //}

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }

            Console.ReadKey();
        }
    }
}
```
Collection demo 4:

```csharp
using System.Collections;

namespace coldemo4_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack st = new Stack();

            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Push(50);

            //foreach(object o in st) 
            //{
            //    Console.WriteLine(o);
            //}

            //Console.WriteLine(st.Peek());
            Console.WriteLine(st.Pop());

            Console.ReadKey();
        }
    }
}
```
Collection demo 5:

```csharp
using System.Collections;

namespace coldemo5_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);

            //foreach (object o in q)
            //{
            //    Console.WriteLine(o);
            //}

           // Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());

            Console.ReadKey();
        }
    }
}
```
Collection demo 6

```csharp
using System.Collections;

namespace coldemo6_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add(102, "ram");
            sl.Add(103, "akash");
            sl.Add(101, "ganesh");

            foreach(DictionaryEntry d in  sl) 
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }

            Console.ReadKey();
        }
    }
}
```
Generic demo 7:

```csharp
namespace coldemo7_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> li= new List<int>();

            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);
            li.Add(50);

            Console.WriteLine("\n----------------------using foreach loop------------------------");
            foreach (int n in li)
            {
               Console.WriteLine(n);
            }

            Console.WriteLine("\n----------------------using for loop------------------------");
            for(int i=0;i<li.Count;i++)
            {
                Console.WriteLine(li[i]);
            }

            Console.WriteLine("\n----------------------using iterator------------------------");
            IEnumerator<int> itr = li.GetEnumerator();
            while (itr.MoveNext())
            {
                Console.WriteLine(itr.Current);
            }

            Console.ReadKey();
        }
    }
}
```
Generic demo 2:

```csharp
namespace coldemo8_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(10); 
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Push(50);

            foreach(int n in st)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Pop());

            Console.ReadKey();
        }
    }
}
```
Generic demo 3:

```csharp
namespace coldemo9_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);

            foreach (int n in q)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());

            Console.ReadKey();
        }
    }
}
```
Generic demo 4
```csharp
namespace coldemo10_pre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> d = new Dictionary<int,string>();

            d.Add(101, "pooja");
            d.Add(102, "ram");
            d.Add(103, "soham");

            foreach(KeyValuePair<int,string> kvp in d)
            {
                Console.WriteLine(kvp.Key+" "+kvp.Value);
            }

            Console.ReadKey();
        }
    }
}
```
Generic Demo 5

```csharp
namespace coldemo11_pre
{
    class Employee
    {
        public int empno { get; set; }
        public string empname { get; set; }
        public double salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> elist = new List<Employee>();

        //elist.Add(new Employee { empno = 101, empname = "ram", salary=89000});
        //elist.Add(new Employee { empno = 102, empname = "rahul", salary=87000});
        //elist.Add(new Employee { empno = 103, empname = "suman", salary=66000});

        List<Employee> elist = new List<Employee>() 
                    {
                    new Employee {empno=101,empname="ram",salary=89000 },
                    new Employee {empno=102,empname="rahul",salary=87000 },
                    new Employee {empno=103,empname="suman",salary=66000 }
                    };

            foreach(Employee e in elist)
            {
                Console.WriteLine(e.empno+"\t"+e.empname+"\t"+e.salary);
            }
            Console.ReadKey();

        }
    }
}
```










































