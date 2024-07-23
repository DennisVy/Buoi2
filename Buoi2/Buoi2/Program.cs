using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Tạo danh sách học sinh và thêm thông tin
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Nguyễn Văn A", Age = 17 },
            new Student { Id = 2, Name = "Trương Văn B", Age = 16 },
            new Student { Id = 3, Name = "Ong Đức D", Age = 19 },
            new Student { Id = 4, Name = "Nguyễn Thị F", Age = 15 },
            new Student { Id = 5, Name = "Anh Thư", Age = 18 },
            new Student { Id = 6, Name = "Lê Minh C", Age = 20 },
            new Student { Id = 7, Name = "Phạm Thị G", Age = 18 },
            new Student { Id = 8, Name = "Đặng Văn E", Age = 17 },
            new Student { Id = 9, Name = "Trần Văn H", Age = 16 },
            new Student { Id = 10, Name = "Võ Thị I", Age = 19 }
        };

        Console.WriteLine("Danh sách toàn bộ học sinh:");
        students.ForEach(student => Console.WriteLine(student));
        Console.WriteLine();

        Console.WriteLine("Danh sách học sinh có tuổi từ 15 đến 18:");
        var age15To18 = students.Where(student => student.Age >= 15 && student.Age <= 18);
        age15To18.ToList().ForEach(student => Console.WriteLine(student));
        Console.WriteLine();

        Console.WriteLine("Danh sách học sinh có tên bắt đầu bằng chữ 'A':");
        var nameStartsWithA = students.Where(student => student.Name.StartsWith("A"));
        nameStartsWithA.ToList().ForEach(student => Console.WriteLine(student));
        Console.WriteLine();

        int totalAge = students.Sum(student => student.Age);
        Console.WriteLine($"Tổng tuổi của tất cả học sinh: {totalAge}");
        Console.WriteLine();

        int maxAge = students.Max(student => student.Age);
        var oldestStudents = students.Where(student => student.Age == maxAge);
        Console.WriteLine("Học sinh có tuổi lớn nhất:");
        oldestStudents.ToList().ForEach(student => Console.WriteLine(student));
        Console.WriteLine();

        Console.WriteLine("Danh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
        var sortedStudents = students.OrderBy(student => student.Age);
        sortedStudents.ToList().ForEach(student => Console.WriteLine(student));
    }
}
