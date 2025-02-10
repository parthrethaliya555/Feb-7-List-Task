using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Feb_7_List_Task.Model;


namespace Feb_7_List_Task.BAL
{

    public class Student
    {
        public List<StudentModel3> GetStudentList()
        {
            List<StudentModel3> lstStudent = new();
            lstStudent.Add(new StudentModel3()
            {
                Id = 1,
                Name = "Jaypal",
                DOB = DateTime.Now.AddYears(-25),
                Gender = "M",
                RollNo = "RL_1",
                Std = 12,
                SurName = "Vasveliya"
            });
            lstStudent.Add(new StudentModel3()
            {
                Id = 2,
                Name = "Milan",
                DOB = DateTime.Now.AddYears(-22),
                Gender = "M",
                RollNo = "RL_2",
                Std = 12,
                SurName = "Gandhi"
            });
            lstStudent.Add(new StudentModel3()
            {
                Id = 3,
                Name = "Khushi",
                DOB = DateTime.Now.AddYears(-24),
                Gender = "F",
                RollNo = "RL_3",
                Std = 12,
                SurName = "Mehta"
            });

            return lstStudent;
        }

        public List<string> GetStudentBasedOnAge(int age) //5
        {
            List<StudentModel3> lstStudent = GetStudentList(); //3
            int year = DateTime.Now.AddYears(-age).Year; //2020
            List<StudentModel3> flterList = new(); //0
            foreach (StudentModel3 student in lstStudent)
            {
                if (year > student.DOB.Year)//2020 < 2000 
                {
                    flterList.Add(student);
                }
            }
            return flterList.Select(x => x.Name).ToList();
        }
        public List<string> GetFullName() //show name + surname
        {
            List<StudentModel3> lstStudent = GetStudentList();
            List<string> fullnames = new();

            foreach (StudentModel3 student in lstStudent)
            {
                string fullname = student.Name + " " + student.SurName; fullnames.Add(fullname);
            }
            return fullnames;

        }
        public List<string> AllNameCaps() //all name Capital
        {
            List<StudentModel3> studentp = GetStudentList();


            foreach (StudentModel3 student in studentp)
            {


                Console.WriteLine($"{student.Name?.ToUpper()}");

            }
            return studentp?.Select(x => x.Name).ToList();
        }
        public List<StudentModel3> AddNewStudent(int id, string Name, string Surname, string Rollno, string Gender, DateTime Dob, int std) //add new student 
        {
            List<StudentModel3> lstStudent = GetStudentList();
            StudentModel3 student1 = new StudentModel3 { Id = id, Name = Name, SurName = Surname, RollNo = Rollno, Gender = Gender, DOB = Dob, Std = std };
            lstStudent.Add(student1);
            foreach (StudentModel3 student in lstStudent)
            {
                Console.WriteLine("ID:{0},StudentName is:{1} ,Surname is:{2}, Roll-no:{3} , Gender:{4} , Dob:{5} , Std:{6} ",student.Id,student.Name,student.SurName,student.RollNo,student.Gender,student.DOB,student.Std);

            }

            return lstStudent;


        }

        //public List<string> StartWith(string? charactor)
        //{
        //    List<StudentModel3> lstStudent = GetStudentList();
        //    return lstStudent.Where(Student => Student.Name.StartsWith(charactor.ToString()

        //}






        public List<string> GetStudentAgeRange(int start, int end) //Get Student age range

        {
            List<StudentModel3> lstStudent = GetStudentList();
            List<StudentModel3> filterList4 = new();
            int year = DateTime.Now.Year;


            foreach (StudentModel3 student2 in lstStudent)
            {
                if (student2.DOB.Year <= DateTime.Now.AddYears(-start).Year && student2.DOB.Year >= DateTime.Now.AddYears(-end).Year)
                {
                    filterList4.Add(student2);

                }
            }


            return filterList4.Select(x => x.Name + " Year of birth: " + x.DOB.Year + " Age: " + (DateTime.Now.Year - x.DOB.Year)).ToList();

        }


            public List <string> ShowDOB() //show Dob
         {
            List<StudentModel3> lstStudent = GetStudentList();
            List<string> list3 = new List<string>();
            foreach (StudentModel3 student in lstStudent)
            {  
              string birthdate =student.DOB.ToString("dd MMMM yyyy");
                list3.Add(birthdate);

               

            }

            return list3;

          }
        //public List<string> ChangeSurname(int id,string surname) 
        //{
        //    List<StudentModel3> list2 = GetStudentList();
        //    foreach (StudentModel3 student in list2)
        //    {
        //        if (id == student.Id)
        //        {
        //            string student3 = student.SurName.Replace;
        //        }
              
        //    }


        //}

        public List<string> GetUpdatedStudentlist()//Repalce method 
        {
            List<StudentModel3> list2 = GetStudentList();
            List<string> strings = new List<string>();
            foreach (StudentModel3 student in list2)
            {
                 string rollno = student.RollNo.Replace("RL", "#");
               
                strings.Add(rollno);    
            }

            return  strings;
        }


    }




} 





