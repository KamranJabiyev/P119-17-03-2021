using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericTypeCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GenericType
            //MyStringList myStringList = new MyStringList();
            //myStringList.Add("Orkhan");
            //myStringList.Add("Agha");

            //MyIntList myIntList = new MyIntList();
            //myIntList.Add(1);
            //myIntList.Add(2);

            //MyList<string> myStringList = new MyList<string>();
            //myStringList.Add("Orkhan");
            //myStringList.Add("Agha");

            //MyList<int> myIntList = new MyList<int>();
            //myIntList.Add(1);
            //myIntList.Add(2);

            //MyList<Person> myPersonList = new MyList<Person>();
            //myPersonList.Add(new Person());

            //MyList<Person,IRun> myList=new MyList<Person, IRun>();

            //Print(5);
            //Print(new Person());
            #endregion

            #region Collections
            #region ArrayList
            //ArrayList list = new ArrayList();
            //list.Add(3);
            //list.Add("Orkhan");
            //list.Add(new Person());
            //list.Add(new int[2] { 1,2});
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.GetType());
            //}
            #endregion

            #region List
            //List<string> strList = new List<string>();
            //strList.Add("Aga");
            //strList.Add("Tebriz");
            //strList.Add("Orkhan");
            //strList.Clear();
            //string isExist = strList.Find(item => item == "sadsd");
            //Console.WriteLine(isExist);
            //Console.WriteLine(strList.Contains("adsfadg"));
            //foreach (string item in strList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region HashTable,Dictionary,SortedList

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("first", "Orkhan");
            //hashtable.Add(2, "Agha");

            //Dictionary<string, string> phones = new Dictionary<string, string>();
            //phones.Add("Kamran", "+994512373434");
            //phones.Add("Orkhan", "+994512373434");
            //phones.Add("Agha", "+994512373434");
            //foreach (var item in phones)
            //{
            //    if (item.Key == "Kamran") continue;
            //    Console.WriteLine(item.Key+"-"+item.Value);
            //}
            //Dictionary<int, string> dicList = new Dictionary<int, string>();
            //dicList.Add(2, "Two");
            //dicList.Add(0, "Zero");
            //dicList.Add(4, "Four");
            //dicList.Add(1, "One");
            //dicList.Add(3, "Three");

            //Console.WriteLine("Dictionary");
            //foreach (var item in dicList)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //Console.WriteLine("====================================================");

            //SortedList<int, string> sortList = new SortedList<int, string>();
            //sortList.Add(2, "Two");
            //sortList.Add(0, "Zero");
            //sortList.Add(4, "Four");
            //sortList.Add(1, "One");
            //sortList.Add(3, "Three");
            //Console.WriteLine("SortedList:");
            //foreach (var item in sortList)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}
            #endregion

            #region Queue - FIFO
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Orkhan");
            //queue.Enqueue("Ferid");
            //queue.Enqueue("Agha");

            //Console.WriteLine("Ilk novbeden chixan"+" - "+queue.Dequeue());

            //Console.WriteLine($"Hazirda novbe kimdedir: - {queue.Peek()}");

            //Console.WriteLine("Novbedekiler:");
            //foreach (string item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack - LIFO
            //Stack<string> stack = new Stack<string>();
            //stack.Push("Orkhan");
            //stack.Push("Ferid");
            //stack.Push("Agha");

            //Console.WriteLine($"Ilk novbeden cixan: - {stack.Pop()}");

            //Console.WriteLine($"Hazirda novbede olan: - {stack.Peek()}");

            //Console.WriteLine("Novbedekiler:");
            //foreach (string item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }

        #region Generic type method
        //static void Print<T>(T item)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
    }

    #region GenericType

    //generic type constraint
    //class MyList<T, U> where T : class, IRun, new()
    //class MyList<T, U> where T : class
    //class MyList<T, U> where T : struct
    //class MyList<T, U> where T : IRun
    //class MyList<T, U> where T : class, IRun, new() where U : struct
    class MyList<T,U> where T:U
    {
        private T[] list;

        public MyList()
        {
            list = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = item;
        }

        public void ShowType(U u)
        {
            Console.WriteLine(u.GetType());
        }
    }

    //class MyList<T>
    //{
    //    private T[] list;

    //    public MyList()
    //    {
    //        list = new T[0];
    //    }

    //    public void Add(T item)
    //    {
    //        Array.Resize(ref list, list.Length + 1);
    //        list[list.Length - 1] = item;
    //    }
    //}

    #region Sehv yanashma
    //class MyPersonList
    //{
    //    private Person[] list;

    //    public MyPersonList()
    //    {
    //        list = new Person[0];
    //    }

    //    public void Add(Person item)
    //    {
    //        Array.Resize(ref list, list.Length + 1);
    //        list[list.Length - 1] = item;
    //    }

    //}

    //class MyIntList
    //{
    //    private int[] list;

    //    public MyIntList()
    //    {
    //        list = new int[0];
    //    }

    //    public void Add(int item)
    //    {
    //        Array.Resize(ref list, list.Length + 1);
    //        list[list.Length - 1] = item;
    //    }

    //}

    //class MyStringList
    //{
    //    private string[] list;

    //    public MyStringList()
    //    {
    //        list = new string[0];
    //    }

    //    public void Add(string item)
    //    {
    //        Array.Resize(ref list, list.Length + 1);
    //        list[list.Length - 1] = item;
    //    }

    //}
    #endregion

    interface IRun
    {

    }

    class Person:IRun
    {
        public Person()
        {

        }
        public Person(int x)
        {

        }
    }

    #endregion
}
