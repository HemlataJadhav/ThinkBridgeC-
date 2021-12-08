using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ClassLibraryDemo;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new Circle(3);
            //circle.CalculateArea();
            //Console.WriteLine(circle);
            //circle.PrintableDtails();



            //Rectangle rect = new Rectangle(3, 4);
            //rect.CalculateArea();
            //Console.WriteLine(rect);

            //Console.WriteLine();
            //Console.ReadKey();

            //Exception_Handling exception_Handling = new Exception_Handling();
            //try
            //{
            //    int result1 = exception_Handling.Calculate(3, 0);
            //    Console.WriteLine(result1);


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("divide by zero exception" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("in finally block");
            //}

            ////another exception handling code
            //Person person = new Person();
            //try
            //{
            //    int age = person.AcceptAge(13);
            //    Console.WriteLine("you are valid user:" + age);
            //}
            //catch (AgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();


            //Person1 person1 = new Person1();
            //try
            //{
            //    string name= person1.AcceptName("");
            //    Console.WriteLine("name is:" + name);
            //}
            //catch (NameException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();

            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add(2.2);
            //list.Add("hema");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("after inserting at 2nd position");
            //list.Insert(2, 12);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2.1);
            //stack.Push("raj");
            //stack.Push(7654);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------after pop---------------------------");
            //stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue queue = new Queue();
            //queue.Enqueue(3);
            //queue.Enqueue(76.45);
            //queue.Enqueue("arav");
            //queue.Enqueue("arun");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine( item);
            //}
            //Console.WriteLine("----------------after Dequeue operation------ ");
            //Console.WriteLine();
            //queue.Dequeue();

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList = new ArrayList();
            //Product monitor= new Product {Code=111,Price=3652.4553,Name="Lenovo"};
            //Product TV = new Product { Code=112,Price=76532.54,Name="Samsung"};
            //Product Printer = new Product {Code=113,Price=6543.232,Name="HP" };
            //arrayList.Add(monitor);
            //arrayList.Add(TV);
            //arrayList.Add(Printer);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable hashtable = new Hashtable();


            //Hashtable_Demo a = new Hashtable_Demo();
            //hashtable = a.Add_Elements(hashtable);
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            //hashtable.Remove(2);
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}


            //Test.Test1<int> test = new Test.Test1<int>(10);
            //Console.WriteLine(test.Print());

            //Test.Test1<string> test1 = new Test.Test1<string>("raj");
            //Console.WriteLine(test1.Print());



            //List<Product> list = new List<Product>();
            //Product monitor= new Product {Code=111,Price=3652.4553,Name="Lenovo"};
            //Product TV = new Product { Code=112,Price=76532.54,Name="Samsung"};
            //Product Printer = new Product {Code=113,Price=6543.232,Name="HP" };
            //list.Add(monitor);
            //list.Add(TV);
            //list.Add(Printer);


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("----------------------after sorting-----------------");
            //Console.WriteLine();
            //list.Sort();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<string> stack = new Stack<string>();
            //stack.Push("Raj");
            //stack.Push("arav");
            //stack.Push("kiran");
            //stack.Push("arun");
            //stack.Push("harsh");

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("after pop");



            //Dictionary Demo 

            //Dictionary<int, string> d = new Dictionary<int, string>();
            //d.Add(1, "Test1");
            //d.Add(2, "Test2");



            //foreach (KeyValuePair<int, string> item in d)
            //{
            //    Console.WriteLine(item.Key + "   " + item.Value);
            //}

            Calculate calculate = new Calculate();
            
            Console.WriteLine(calculate.Addition(12, 23));
            Console.WriteLine(calculate.Square(2));

            Console.ReadKey();
            
        }

    }
}
