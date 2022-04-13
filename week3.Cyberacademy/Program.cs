using System;

namespace week3.Cyberacademy
{
    public delegate int MyDelegate(int i);
    public class Program
    {
        static void Main()
        {

            MyDelegate del = MyMethod;
            del += MyMethod2;
            del(89);
            //People p = new People();

            //People.Person person = p[1];
            //Console.WriteLine(person.Name);
        }
        static void MyMethod(int i)
        {
            Console.WriteLine("MyMethod {0}", i);
        }
        static void MyMethod2(int i)
        {
            Console.WriteLine("MyMethod2 {0}", i);
        }
    }
}

//public class People
//{
//    public class Person
//    {
//        public string Name { get; set; }
//}
//private readonly Person[] names =
//    {
//        new Person{ Name = "Bill gate"},
//        new Person{ Name = "Prolifik lexzy" },
//        new Person{ Name = "Scott Allen"},
//        new Person{ Name = " Damilare Obafemi"}
//    };

//    public Person this[int position]
//    {
//        get
//        {
//            return names[position];
//        }
//    }
//}


