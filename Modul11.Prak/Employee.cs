using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11.Prak
{
    public enum Vacancies
    {
        Manager, Менеджер,
        Developer, Разработчик,
        Designer, Дизайнер,
        Tester, Тестировшик
    }
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public int[] HireDate { get; set; }
        public int Salary { get; set; }
        public  string VacancyToString( Vacancies vacancy)
        {
            switch (vacancy)
            {
                case Vacancies.Manager:
                    return "Менеджер";
                case Vacancies.Developer:
                    return "Разработчик";
                case Vacancies.Designer:
                    return "Дизайнер";
                case Vacancies.Tester:
                    return "Тестировщик";
                default:
                    return null;
            }
        }

        public Employee(string name, Vacancies vacancy, int[] hireDate, int salary)
        {
            Name = name;
            Vacancy = vacancy;
            HireDate = hireDate;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Должность: {VacancyToString(Vacancy)}, Дата назначения на должность: {String.Join("/", HireDate)}, Зарплата: {Salary}";
        }
    }
}
