using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
/*
 * Придумать класс описывающий студента и предусмотреть в нем следующие моменты :
 *  фамилия, 
 *  имя, 
 *  отчество, 
 *  группа, 
 *  возраст,
 *  массив(рваный) оценок по:
 *                          программированию, 
 *                          администрированию, 
 *                          дизайну. 
 * А также добавить методы по работе с перечисленными данными: 
 *  возможность установки\получения оценки, 
 *  получение среднего балла по заданному предмету, 
 *  распечатка данных о студенте.
 */
namespace ItStepTasks
{
    enum Subject
    {
        Programming,
        Administration,
        Design
    }
    class Student
    {
#region Property
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PetName { get; private set; }
        public string Group { get; set; }
        public int Age { get; private set; }
        #endregion
#region Field
        private readonly int[][] Assessments = new int[3][];
        private readonly float[] AvgAssessments = new float[3];
#endregion
        public Student(string firstName, string lastName, string petName, int age, string group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PetName = petName;
            this.Age = age;
            this.Group = group;            
        }

        public void AddAssessmets(Subject subject, params int[] ass)
        {
            for (int i = 0; i < ass.Length; i++)
            {
                if (ass[i] < 1 || ass[i] > 10)
                { 
                    Console.WriteLine($"ОШИБКА !!!!! : {i + 1} равна {ass[i]}. " +
                        $"Оценка должна быть в интервале от 1 до 10. ");
                    return;
                 }
            }
            int totalAssessments=0;

            if (Assessments[(int)subject] == null)
            {
                Assessments[(int)subject] = new int[ass.Length];
                AddAss(subject, ass, totalAssessments);
                totalAssessments = Assessments[(int)subject].Length;
            }
            else
            {
                totalAssessments = Assessments[(int)subject].Length;
                Array.Resize(ref Assessments[(int)subject], Assessments[(int)subject].Length + ass.Length);
                AddAss(subject, ass, totalAssessments);
                totalAssessments = Assessments[(int)subject].Length;
            }

            float avg = 0;
            for (int i = 0; i < totalAssessments; i++)
            {
                avg += Assessments[(int)subject][i];
            }
            avg /= totalAssessments;
            AvgAssessments[(int)subject] = avg;
        }

        private void AddAss(Subject subject, int[] ass, int totalAssessments)
        {
            for (int i = 0; i < ass.Length; i++)             
                Assessments[(int)subject][totalAssessments + i] = ass[i];     
        }

        public float GetAvgProgramming()
        {
            return AvgAssessments[(int)Subject.Programming];
        }

        private void ShowAssessments(Subject subject)
        {
            int index = (int)subject;
            Console.WriteLine($"Предмет: {subject}");
            if(Assessments[index] == null)
            {
                Console.WriteLine("Неатестация");
                return;
            }
            foreach (var item in Assessments[index])
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nСредний бал по предмету {AvgAssessments[index]}");
            Console.WriteLine();
        }
        private void Separator()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine(this.ToString());
            Separator();
            ShowAssessments(Subject.Administration);
            ShowAssessments(Subject.Design);
            ShowAssessments(Subject.Programming);
            Separator();
            Console.WriteLine();
        }

        public int[] GetAssessments(Subject subject)
        {
            return Assessments[(int)subject];
        }
        public override string ToString()
        {
            return $"Информация о студенте : \n\t {LastName} {FirstName}  {PetName}, возраст: {Age}, группа: {Group}\n";
        }
    }

    class Task11
    {
        public void DoAction()
        {
            Student student = new Student("Алексей", "Матвеев", "Владимирович", 41, "Разработка ПО");
            
            student.AddAssessmets(Subject.Administration, 25, 5, 5, 5, 5, 5);
            student.AddAssessmets(Subject.Programming, 5, 4); 
            student.AddAssessmets(Subject.Design, 9, 6, 8);
            student.ShowStudentInfo();
            student.AddAssessmets(Subject.Administration, 5, 5, 5, 5, 5, 5);
            student.ShowStudentInfo();

            Student student1 = new Student("Роман", "Матвеев", "Алексеевич", 7, "Графика и Дизайн");
            student1.AddAssessmets(Subject.Administration, 6, 5, 7, 3, 2, 9, 9);
            student1.AddAssessmets(Subject.Programming, 5, 4, 7, 8, 4, 3, 8);
            student1.AddAssessmets(Subject.Design, 9, 9, 8, 9, 9, 12, 1);
            student1.ShowStudentInfo();
        }
    }
}