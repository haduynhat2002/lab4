using System;
using System.Text;

namespace lab4.lab4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public int Salazy { get; set; }
        public int DateHired { get; set; }
        public abstract int CalculateVacation();
        public abstract double CalculateBonus();
    }
}