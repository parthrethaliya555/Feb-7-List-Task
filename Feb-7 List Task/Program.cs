// See https://aka.ms/new-console-template for more information
using Feb_7_List_Task.BAL;
using Feb_7_List_Task.Model;

Console.WriteLine("Hello, World!");



Student objStudent = new();
//List<string> lstStudentName = objStudent.GetStudentBasedOnAge(24);
//foreach (string studentName in lstStudentName)
//{
//    Console.WriteLine(studentName);
//}
//List<StudentModel3> lstStudent = objStudent.GetStudentList();

//for (int i = 0; i < lstStudent.Count; i++)
//{
//   Console.WriteLine(lstStudent[i].Name);
//}

//foreach (StudentModel3 student in lstStudent)
//{
//    if (student.Gender == "F")
//    {
//        Console.WriteLine(student.Name);
//    }
//}
//if(student.DOB)

//Console.WriteLine(student.Gender == "F" ? student.Name : "Condition Not Satisfied");

//List<string> lstStudentName2 = objStudent.GetStudentAgeRange(11,25);
//foreach (string studentName in lstStudentName2)
//{
//    Console.WriteLine(studentName);
//}

//List<string> lstStudent2 = objStudent.GetFullName();
//foreach (string name in lstStudent2)
//{
//    Console.WriteLine(name);
//}

//List<string> studentR = objStudent.AllNameCaps();



//List <StudentModel3> newstudent1 = objStudent.AddNewStudent(4, "Parth", "Rethaliya", "RL_4", "M", DateTime.Now.AddYears(-26), 12);

//List<string> lstStudentName2 = objStudent.StartWith("p");
//foreach (string studentName in lstStudentName2)
//{
//    Console.WriteLine(studentName);
//}
//List<string> lstStudentName = objStudent.ShowDOB();

//foreach (string s in lstStudentName)
//{
//    Console.WriteLine(s);
//}
//List<string> students2 = objStudent.GetUpdatedStudentlist();

//foreach (string student in students2)
//{
//    Console.WriteLine(student);


//}
List<string> agerange = objStudent.GetStudentAgeRange(20, 24);
foreach (string student in agerange)
{
    Console.WriteLine(student);
}
