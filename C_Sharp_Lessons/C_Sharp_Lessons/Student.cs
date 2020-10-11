using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Lessons
{
    public class Student
    {
        public string name;
        public int age;
        public int course;
        public void SetName(string name)
        {
            this.name = name;
        } 
        public void SetAge(int age)
        {
            this.age = age;
        }

        /* public Student(string name,int age,int course)
         {
             this.name = name;
             this.age = age;
             this.course = course;
         }*/
        
    }
}
