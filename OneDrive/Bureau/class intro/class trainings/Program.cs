using System;

namespace class_trainings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region class intro
            //string name = "Ehmed";
            //string surname = "Jabrayilov";
            //int age = 24;
            //string name1 = "Ilkin";
            //string surname1 = "Ibrahimov";
            //int age1 = 20;
            //anonim
            //var Ehmed = new
            //{
            //    name = "Ehmed",
            //    surname = "Jabrayilov",
            //    age = 24,
            //};
            //var Kamal = new
            //{
            //    name = "Kamal",
            //    surname = "Abdullayev",
            //    age = 20,
            //};
            //Console.WriteLine(Ehmed.name);
            //Console.WriteLine(Kamal.surname);
            #endregion class intro
            //instance
            //int num = 4
            student stu1 = new student("Ehmed","Jabrayilov",24);
            stu1.name = "Lorem";
            //stu1.age = 24;
            //stu1.surname = "Jabrayilov";
            stu1.Fullname();
            //stu1.GetAge();
            Console.WriteLine(stu1.GetAge());
            //student stu2 = new student();
            //stu2.name = "Kamal";
            //stu2.age = 20;
            //stu2.surname = "Abdullayev";
            //stu2.Fullname();
            //stu2.GetAge();
            //Console.WriteLine(stu2.GetAge());
            //Console.WriteLine(stu1.name);
            //Console.WriteLine(stu2.surname);
        }
    }
    class student
    {
        //fields
        public string name;
        public int age = 5;
        public string surname;
        //contructor
        //1.classin adi ile eynidir
        //2.ilk ishe dushen metoddur
        //3.return type olmur
        public student(string name, string surname, int age)
        {
           this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public void Fullname()
      

        {
            Console.WriteLine($"{name},{surname}");
        }
        public int GetAge()
        {
            return age;
        }
    }
}

