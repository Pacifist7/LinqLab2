var studentList  = new List<Student>()
{ 
new Student() { Name = "Jimmy", Age= 13},
new Student(){Name = "Hannah", Age = 21 },
new Student(){Name = "Justin", Age = 30},
new Student(){Name = "Sarah", Age = 53},
new Student(){Name = "Hannibal", Age = 15},
new Student(){Name = "Phillip",Age = 16},
new Student(){Name = "Maria", Age = 63},
new Student(){Name = "Abe", Age = 33},
new Student(){Name = "Curtis", Age = 10},
};


//Find all students age of 21 and over (aka US drinking age) 

var age21AndOver = studentList.Where(x => x.Age >= 21).ToList();
foreach (var student in age21AndOver)
{
    Console.WriteLine(student.Name);
}


//Find the oldest student 
var oldestStudentAge = studentList.Max(x => x.Age);
var oldestStudent = studentList.Where(x => x.Age == oldestStudentAge).FirstOrDefault();
Console.WriteLine(oldestStudent.Name);


//Find the youngest student
var youngestStudentAge = studentList.Min(x => x.Age);
var youngestStudent = studentList.Where(x => x.Age == youngestStudentAge).FirstOrDefault();
Console.WriteLine(youngestStudent.Name);


//Find the oldest student under the age of 25 
var oldestStudentunder25 = studentList.Where(x => x.Age <= 25);

//Find all students over 21 and with even ages




//Find all teenage students (13 to 19 inclusive) 
var teenagers = studentList.Where(x => x.Age >= 13 && x.Age <= 19).ToList();


//Find all students whose name starts with a vowel
var vowelList = new List<string>() { "A", "E", "I", "O", "U" };
var list = studentList.Where(x => vowelList.Contains(x.Name[0].ToString())).ToList();
foreach (var s in list)
{
    Console.WriteLine(s.Name);
}























