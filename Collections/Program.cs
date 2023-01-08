
using Collections.Models;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Transactions;




#region Operator overloading




//Employee employee1 = new Employee();

//employee1.Name = "Pervin";
//employee1.Age = 25;
//employee1.Id = 1;


//Employee employee2 = new Employee();

//employee1.Name = "Cavid";
//employee1.Age = 22;
//employee1.Id = 2;


////var result = employee1.Age > employee2.Age;

//var result = employee1 > employee2;
//Console.WriteLine(result);

#endregion


#region Hashtable



//Hashtable datas = new Hashtable();

//datas.Add(1, "Cavid");
//datas.Add(2, "Pervin");
//datas.Add(3, "Mirze");

//foreach (var item in datas.Keys /*Values*/)

//{
//    Console.WriteLine(item);
//}

//foreach (DictionaryEntry item in datas)

//{
//    Console.WriteLine(item.Key + " - " + item.Value);
//}


//foreach (DictionaryEntry item in datas)
//{
//    if ((int)item.Key == 1)
//    {
//        Console.WriteLine(item.Value);
//    }
//}

#endregion

#region SortedList



//SortedList datas = new SortedList();

//datas.Add(1, "Cavid");
//datas.Add(6, "Pervin");
//datas.Add(3, "Mirze");




//foreach (DictionaryEntry item in datas)
//{   
//   Console.WriteLine(item.Key + "-" +item.Value);

//}

#endregion

#region ArrayList


//ArrayList datas = new ArrayList();

//datas.Add("Salam");
//datas.Add(1);
//datas.Add(true);

//foreach ( var item in datas)
//{
//    Console.WriteLine(item);
//}

#endregion


#region List



//List<int> datas= new List<int>();

//datas.Add(10);
//datas.Add(40);   
//datas.Add(30);
//datas.Add(20);


//datas.Sort();
//datas.Reverse();

//datas.Clear();

//datas.RemoveAll(m => m == 20);

//var result = datas.Contains(20);

//Console.WriteLine(result);


//Console.WriteLine(datas[0]);

//datas.Remove(40);
//datas.RemoveAt(0);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}


//List<string> names = new List<string>() { "Cavid","Cavid" , "Mirze", "Akshin", "Elcan" };


//Console.WriteLine(names.Count);

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);

//}

//foreach (var item in names)
//{
//    if(item == "Hesen")
//    {
//        Console.WriteLine(item);

//    }
//}

//var result = names.Find(m => m == "Cavid");
//{
//    Console.WriteLine(result);
//}

//var result = names.FindAll(m => m == "Cavid");
//{
//    foreach(var item in result)
//    {
//        Console.WriteLine(item);
//    }

//}

//var result = names.FindAll(m => m == "Cavid").Count;

//    Console.WriteLine(result);


//List<int> numbers = new List<int>() { 1, 2, 3, 4 };

//Console.WriteLine(numbers.Sum(m=>m));

//Console.WriteLine(numbers.FindAll(m=>m%2==0).Sum(m => m));

//var res = numbers.FindAll(m => m %2 == 0);

//foreach( var item in res)
//{
//    Console.WriteLine(item);
//}


//var sum = numbers.FindAll(m => m % 2 == 0).Sum(m=>m);

//Console.WriteLine(sum);


//List<Student> students = new();

//Student stu1 = new Student
//{
//    Id = 1,
//    FullName = "Roya Meherremova",
//    Age = 25,
//    Address = "Sumqayit"
//};


//Student stu2 = new Student
//{
//    Id = 2,
//    FullName = "Ferid Abdulayev",
//    Age = 17,
//    Address = "Nesimi"
//};


//Student stu3 = new Student
//{
//    Id = 3,
//    FullName = "Shaiq Kazimov",
//    Age = 25,
//    Address = "Sedmoy"
//};

//Student stu4 = new Student
//{
//    Id = 4,
//    FullName = "Elcan Qurbanov",
//    Age = 19,
//    Address = "New Blaxani"
//};

//Student stu5 = new Student
//{
//    Id = 5,
//    FullName = "Konul Ibrahimova",
//    Age = 26,
//    Address = "Nefciler"
//};


//students.Add(stu1);
//students.Add(stu2);
//students.Add(stu3);
//students.Add(stu4);
//students.Add(stu5);


//students.AddRange();



//foreach (var item in students)
//{
//    Console.WriteLine(item.FullName);
//}

//Student stu2 = new Student
//{
//    Id = 2,
//    FullName = "Ferid Abdulayev",
//    Age = 17,
//    Address = "Nesimi"
//};


//AddStudent(stu2);



//Console.WriteLine("Add full name");

//string FullName = Console.ReadLine();


//Console.WriteLine("Add address");

//string adress = Console.ReadLine();


//Console.WriteLine("Add age");

//int age =Convert.ToInt32 (Console.ReadLine());


//Student student = new Student
//{
//    Id = 1,
//    FullName = FullName,
//    Address = adress,
//    Age = age


//};

//AddStudent(student);


//static void AddStudent(Student student)
//{
//    List<Student> students = new();

//    students.Add(student);

//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName + "-" + item.Address);
//    }

//}


//Console.WriteLine(GetStudentsCount());
//static int GetStudentsCount()
//{
//    var students= GetAllStudents();
//    return students.Count;
//}

//Console.WriteLine(GetSameNameCount());

//static int GetSameNameCount()
//{
//    string text = "Konul";

//    var result = GetAllStudents();

//    //return result.FindAll(m => m.FullName == text).Count;

//    return result.FindAll(m => m.FullName.Contains(text)).Count;
//}







//static List<Student> GetAllStudents()
//{

//    List<Student> students = new();

//    Student stu1 = new Student
//    {
//        Id = 1,
//        FullName = "Roya Meherremova",
//        Age = 25,
//        Address = "Sumqayit"
//    };


//    Student stu2 = new Student
//    {
//        Id = 2,
//        FullName = "Ferid Abdulayev",
//        Age = 17,
//        Address = "Nesimi"
//    };


//    Student stu3 = new Student
//    {
//        Id = 3,
//        FullName = "Shaiq Kazimov",
//        Age = 25,
//        Address = "Sedmoy"
//    };

//    Student stu4 = new Student
//    {
//        Id = 4,
//        FullName = "Elcan Qurbanov",
//        Age = 19,
//        Address = "New Blaxani"
//    };

//    Student stu5 = new Student
//    {
//        Id = 5,
//        FullName = "Konul Ibrahimova",
//        Age = 26,
//        Address = "Nefciler"
//    };

//    Student stu6 = new Student
//    {
//        Id = 6,
//        FullName = "Konul Eliyeva",
//        Age = 26,
//        Address = "Nefciler"
//    };




//    students.Add(stu1);
//    students.Add(stu2);
//    students.Add(stu3);
//    students.Add(stu4);
//    students.Add(stu5);
//    students.Add(stu6);

//    return students;


//}



#endregion


#region SortedList




//SortedList<int,string> datas = new SortedList<int,string>();

//datas.Add(2, "Cavid");

//datas.Add(1, "Pervin");

//  foreach ( KeyValuePair<int,string>  item in datas)
//  {
//    Console.WriteLine(item.Key + " " + item.Value);

//  }

#endregion


#region HashSet



//HashSet<int>datas = new HashSet<int>(); 

//datas.Add(1);
//datas.Add(2);   
//datas.Add(1);   
//datas.Add(4);

//foreach(var item in datas)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Stack-Queue



//Stack<string> stack= new Stack<string>();

//stack.Push("Salam");

//stack.Push("Sagol");

//stack.Push("Necesen");




//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}


//Queue<string> queue= new Queue<string>();

//queue.Enqueue("Salam");

//queue.Enqueue("Sagol");

//queue.Enqueue("Necesen");

//foreach(var item in queue)
//{
//    Console.WriteLine(item);
//}


#endregion


#region Dictionary




//Dictionary<string, string> datas = new Dictionary<string, string>();

//datas.Add("Admin", "Mirze");
//datas.Add("Member", "Hacker");
//datas.Add("SuperAdmin", "Anar");

//foreach(KeyValuePair<string, string> item in datas)
//{
//   if(item.Key == "Admin")
//   {
//        Console.WriteLine(item.Value);
//   }

//}

//foreach (KeyValuePair<string, string> item in datas)
//{
//    Console.WriteLine(item.Key + " " + item.Value);

//}



#endregion





#region Kelvin ve Celsius


//Kelvin kelvin = new Kelvin();
//Celsius celsius = new Celsius();
//Console.WriteLine("Enter celsius degree:");
//double c = double.Parse(Console.ReadLine);

//double f = (c * 9 / 5) + 32;
//double k = c * 273.15;

//Console.WriteLine("From celsius to kelvin: " + k);

//Console.WriteLine("From celsius to fahrenheit: " + f);


#endregion


#region Task-Author



//Console.WriteLine(GetAgeCount());
//static int GetAgeCount()
//{

//    var result = GetAllAuthor();
//    return result.FindAll(m => m.Age > 40).Count;

//}


//static List<Author> GetAllAuthor()
//{
//    List<Author> authors = new();

//    Author aut1 = new Author
//    {
//        Name = "Hesen",
//        Surname = "Hesenov",
//        Age = 42


//    };

//    Author aut2 = new Author
//    {
//        Name = "Qadir",
//        Surname = "Hesenov",
//        Age = 44


//    };

//    Author aut3 = new Author
//    {
//        Name = "Samir",
//        Surname = "Hesenov",
//        Age = 35


//    };

//    Author aut4 = new Author
//    {
//        Name = "Serxan",
//        Surname = "Hesenov",
//        Age = 39


//    };

//    Author aut5 = new Author
//    {
//        Name = "Turan",
//        Surname = "Hesenov",
//        Age = 32


//    };

//    authors.Add(aut1);
//    authors.Add(aut2);
//    authors.Add(aut3);
//    authors.Add(aut4);
//    authors.Add(aut5);

//    return authors;

//}


#endregion



#region Employees




//Console.WriteLine(GetSalaryCount);


//var startDate = new DateTime(1996, 01, 01);
//var endDate = new DateTime(2001, 01, 01);


//int Salary = 2000;


//Employees(startDate, endDate, Salary);

//static int GetSalaryCount()
//{

//    var result = GetAllEmployees();


//    return result.FindAll(m => m.Birthday > startDate && m.Birthday < endDate && m.Salary < 2000).Count;

//}




//static List<Employees> GetAllEmployees()
//{


//    Employees emp2 = new Employees
//    {
//        Name = "Samir",
//        Surname = "Qurbanov",
//        Salary = 3000,
//        Birthday = new DateTime(2000, 02, 02)


//    }; List<Employees> employees = new();

//    Employees emp1 = new Employees
//    {
//        Name = "Qadir",
//        Surname = "Hesenov",
//        Salary = 500,
//        Birthday = new DateTime(1995, 01, 01)

//    };





//    Employees emp3 = new Employees
//    {
//        Name = "Qurban",
//        Surname = "Qadirov",
//        Salary = 2100,
//        Birthday = new DateTime(1997, 03, 03)


//    };



//    Employees emp4 = new Employees
//    {
//        Name = "Pervin",
//        Surname = "Serifof",
//        Salary = 100,
//        Birthday = new DateTime(2002, 04, 04)


//    };


//    Employees emp5 = new Employees
//    {
//        Name = "Ali",
//        Surname = "Alizade",
//        Salary = 900,
//        Birthday = new DateTime(2001, 05, 05)


//    };

//    Employees emp6 = new Employees
//    {
//        Name = "Sahib",
//        Surname = "Alizade",
//        Salary = 2200,
//        Birthday = new DateTime(2000, 04, 05)


//    };
//    employees.Add(emp1);
//    employees.Add(emp2);
//    employees.Add(emp3);
//    employees.Add(emp4);
//    employees.Add(emp5);
//    employees.Add(emp6);

//    return employees;




//}




#endregion

