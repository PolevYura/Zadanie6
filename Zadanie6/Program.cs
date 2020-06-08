using System;
using System.Collections.Generic;

namespace zadanie6
{
    class Program
    {
        public class Student
        {
            public string id;
            public string fio;
            public string group;
            public string birthDate;
        }

        static List<Student> studentList = new List<Student>();

        static void DobStudenta(string id, string fio, string birthDate, string group)
        {
            studentList.Add(new Student() { id = id, fio = fio, birthDate = birthDate, group = group });
        }


        static void YdStudenta(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id) studentList.RemoveAt(i);
            }
        }

        static void IzmStudenta(string id, string fio, string birthDate, string group)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    studentList[i].fio = fio;
                    studentList[i].birthDate = birthDate;
                    studentList[i].group = group;
                }
            }

        }

        static void ShowStudentFio()
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + studentList[i].fio);
            }
            Console.WriteLine();
        }

        static void ShowStudentById(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                    Console.WriteLine(
                        studentList[i].id + " - "
                        + studentList[i].fio + " - "
                        + studentList[i].birthDate + " - "
                        + studentList[i].group
                    );
            }
            Console.WriteLine();
        }

        static void ShowStudentAge(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    string[] studentListSplit = studentList[i].birthDate.Split(".");
                    int ourYear = 2020;

                    if (int.TryParse(studentListSplit[2], out int res)) Console.Write("Возраст студента с id " + id + ": " + (ourYear - res) + " лет");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student first = new Student();

            DobStudenta("984", "Михно Иван Всеволодович", "24.05.1895", "TEMY");
            DobStudenta("1777", "Собчак Мартын Никитевич", "12.01.1890", "ANDR");
            DobStudenta("465", "Куроптев Агафон Адрианович", "29.12.1920", "LIKR");
            ShowStudentFio();
            IzmStudenta("1777", "Осипов Семён Иннокентиевич", "19.08.1925", "ANDR");
            ShowStudentById("984");
            // YdStudenta("465");
            ShowStudentAge("465");
        }
    }
}

