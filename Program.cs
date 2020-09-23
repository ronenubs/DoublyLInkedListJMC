using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLInkedListJMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //DList<string> strList = new DList<string>();

            //try
            //{
            //    strList.AddFirst("node1"); //node1
            //    strList.AddLast("node0");//node1 node0
            //    strList.AddFirst("node2");//node2 node1 node0
            //    strList.RemoveFirst();//node1 node0
            //    strList.RemoveLast();//node1
            //    strList.RemoveLast();//{empty list}
            //    strList.RemoveLast();

            //    //Console.Write(strList.Last());
            //}
            //catch(EmptyListException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            
            DList<Person> personsList = new DList<Person>();
            personsList.AddFirst(new Person("Ron", "Ibo", "Enubs", 38,
                "Samal City"));
            personsList.AddLast(new Person("Jet", "Hua", "Li", 55,
                "China"));
            Console.WriteLine(personsList.Last().PersonInfo());
            Console.ReadLine();
        }
    }
}
