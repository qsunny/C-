
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showcase2
{
    /// <summary>
    /// 用户信息
    /// </summary>
    class Person :IComparable<Person>{
        /// <summary>
        /// 年龄
        /// </summary>
        public int age { get; set;}
        public String name{get;set;}
        public String password { get; set; }

        public int CompareTo(Person other)
        {
            return other.age - age;
        }

        public override string ToString()
        {
            return "Name: " + name + ", Age:" + age.ToString()+",Password:"+password;
        }
    }

    class showcase
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>() {
                new Person() { age=23,name="aaron",password="122222"},
                new Person() { age=24,name="paul",password="88888"},
                new Person() { age=25,name="kingdom",password="188888"},
                new Person() { age=26,name="yang",password="199999"},
            };
            foreach(Person p in personList) {
                Console.WriteLine(p);                
            }
            personList.Sort();
            Console.WriteLine("================================================");

            foreach (Person p in personList)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
