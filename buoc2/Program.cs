using System;
using System.Text;
namespace buoc2
{
    public class Person
    {
        private string name;
        protected int age;
        internal string address;
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Ho ten: {name}, Tuoi: {age}, Dia chi: {address}");
        }
    }
    public class Student : Person
    {
        public Student(string name, int age, string address) : base(name, age, address)
        {
        }
        public void ShowStudentAccess()
        {
            Console.WriteLine($"Tuoi (protected): {age}");
            Console.WriteLine($"Dia chi (internal): {address}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student st = new Student("Le Trung Duy", 20, "Da Nang");
            st.ShowInfo();
            st.ShowStudentAccess();
            Console.ReadLine();
        }
    }
}