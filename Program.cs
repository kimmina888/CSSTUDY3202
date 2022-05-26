// See https://aka.ms/new-console-template for more information
using CSSTUDY3202;

static void Main(string[] args)
{
    Car car = new Car();
    car.SetInTime();
    car.SetOutTime();

    Random rand = new Random();
    Console.WriteLine(rand.Next(10, 100));
    Console.WriteLine(rand.Next(10, 100));
    Console.WriteLine(rand.Next(10, 100));
    Console.WriteLine(rand.Next(10, 100));
    Console.WriteLine(rand.Next(10, 100));

    Console.WriteLine(rand.NextDouble());
    Console.WriteLine(rand.NextDouble() * 10);

    List<int> list = new List<int>() { 52, 273, 32, 24 };
    list.Clear();
    /*  list.Add(52);
      list.Add(273);
      list.Add(32);
      list.Add(64);*/
    list.Remove(52);
    foreach (var item in list)
    {
        Console.WriteLine("Count : " + list.Count + "/ titem " + item);
    }

    Console.WriteLine(Math.Abs(-52273));
    Console.WriteLine(Math.Ceiling(52.237));
    Console.WriteLine(Math.Floor(52.273));
    Console.WriteLine(Math.Max(52, 273));
    Console.WriteLine(Math.Min(52, 273));
    Console.WriteLine(Math.Round(52.273));
    Console.WriteLine(Math.PI);


    Hambuger nyam = new Hambuger();
    Product productA = new Product();
    productA.name = "포켓몬 빵";
    productA.price = 1500;
    Product productB = new Product() { name = "소금빵", price = 2000 };
    Product productC = new Product() { name = "보름달" };

    List<Student> students = new List<Student>()
    {
        new Student() { name = "함기훈", grade = 1 },
        new Student() { name = "김다흰", grade = 2 },
        new Student() { name = "김미나", grade = 2 },
        new Student() { name = "김민정", grade = 3 },
        new Student() { name = "김세린", grade = 3 },
        new Student() { name = "김소연", grade = 1 },
        new Student() { name = "김지수", grade = 1 },
        new Student() { name = "김지호", grade = 2 },
        new Student() { name = "김찬희", grade = 3 },
        new Student() { name = "김하늘", grade = 2 },
        new Student() { name = "김효리", grade = 1 }
    };
    /* students.Add(new Student() { name = "함기훈", grade = 1 });
     students.Add(new Student() { name = "김다흰", grade = 2 });
     students.Add(new Student() { name = "김미나", grade = 2 });
     students.Add(new Student() { name = "김민정", grade = 3 });
     students.Add(new Student() { name = "김세린", grade = 3 });
     students.Add(new Student() { name = "김소연", grade = 1 });
     students.Add(new Student() { name = "김지수", grade = 1 });
     students.Add(new Student() { name = "김지호", grade = 2 });
     students.Add(new Student() { name = "김찬희", grade = 3 });
     students.Add(new Student() { name = "김하늘", grade = 2 });
     students.Add(new Student() { name = "김효리", grade = 1 });*/

    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }
    /*foreach (Student student in students)
    {
        if (student.grade > 2)
        {
            students.Remove(student);
        }
    }
    확인, 수정 ok
    제거 x
     */
    for(int i =0; i < students.Count; i++)
    {
        if(students[i].grade > 2)
        {
            students.RemoveAt(i);
        }
    }
    for (int i = students.Count - 1; i >= 0; i--)
    {
        if (students[i].grade > 2)
        {
            students.RemoveAt(i);
        }
    }
}
