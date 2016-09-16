﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Practice
{
    class Student
    {
        //Fields
        private string fullName;
        private string university;
        private int age;
        private double gpa;

        //Properties
        public string Name
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string University
        {
            get { return this.university; }
        }
        public string Major
        {
            get;
            set;
        }
        public double Gpa
        {
            get { return this.gpa; }
            set { this.gpa = value; }
        }


        //Constructors
        public Student()
        {

        }
        public Student(string fullName, int age, string university, string major, double gpa)
        {
            this.fullName = fullName;
            this.age = age;
            this.university = university;
            this.Major = major;
            this.gpa = gpa;
        }

        

        //Methods

        public void PrintAllDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(fullName);
            sb.Append(", ");
            sb.Append(age);
            sb.Append(", ");
            sb.Append(university);
            sb.Append(", ");
            sb.Append(Major);
            sb.Append(", ");
            sb.Append(gpa);

            Console.WriteLine(sb.ToString());
        }
        public void Birthday()
        {
            age++;
        }
    }
}
