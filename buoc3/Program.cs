using System;
using System.Text;
namespace buoc3
{
    public class Student
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18)
                    age = value;
                else
                    Console.WriteLine("Tuoi phai >= 18!");
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Ho ten: {Name}, Tuoi: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student sv = new Student();
            sv.Name = "Trung Duy";
            sv.Age = 17;
            sv.Age = 19;
            sv.DisplayInfo();
            Console.ReadLine();
        }
    }
}