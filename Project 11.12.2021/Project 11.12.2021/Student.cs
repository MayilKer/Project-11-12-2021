using System;
using System.Collections.Generic;
using System.Text;

namespace Project_11._12._2021
{
    class Student
    {
        public string FullName;
        public string Course;
        public string Subject;
        public string University;
        public string Email;
        public int PhoneNumber;
        public Student(string fullname, string course, string subject, string universty, string email, int phonenumber)
        {
            
            FullName = fullname;
            Course = course;
            Subject = subject;
            University = universty;
            Email = email;
            PhoneNumber = phonenumber;
        }
        public void Fullinfo()
        {
            Console.WriteLine($"{FullName} {Course} {Subject} {University} {Email} {PhoneNumber}");
        }
    }
}
