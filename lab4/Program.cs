using System;
using System.Text;
using lab4.lab4;

namespace lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            var student = new Student()
            {
                Name = "Ha Duy Nhat",
                Phone = "09090909",
                Email = "nhattb@gmail.com",
                Program = "ISA"
            };

            var staff = new Staff
            {
                Name = "Duy Hà Nhật",
                Phone = "09090909",
                Email = "nhat@gmail.com",
                Title = "Nhân viên thu ngân",
                Salazy = 550,
                Department = "Kế toán",
                DateHired = 5
            };
            Console.WriteLine(staff.ToString());
            Console.WriteLine($"Thưởng của {staff.Name} là : {staff.CalculateBonus()}");
            Console.WriteLine($"Tuần nghỉ của {staff.Name} là : {staff.CalculateVacation()}");


            var faculty = new Faculty()
            {
                Name = "Nhật Ha Duy",
                Phone = "0987987789",
                Email = "nhat@gmail.com",
                OfficeHour = "8h - 17h00",
                Salazy = 400,
                DateHired = 5,
                Rank = 1,
                Department = "2009m1"
            };
            Console.WriteLine(faculty.ToString());
            Console.WriteLine($"Thưởng của {faculty.Name} là : {faculty.CalculateBonus()}");
            Console.WriteLine($"Tuần nghỉ của {faculty.Name} là : {faculty.CalculateVacation()}");
        }
        
    }
}