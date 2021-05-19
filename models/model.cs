using System; //Виталий Войтов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework_6._3.students;
using homework_6._3.GenerateL;

namespace homework_6._3.models //Переделать программу Пример использования коллекций 
{
    public class model
    {
      List<student> studenti = GenerateList.Generate(20);

        
        public void Print()
        {            
            for (int i = 0; i < studenti.Count; i++)
            {
                Console.WriteLine($"{i,3}. {studenti[i]}");
            }
            Console.WriteLine();
        }

        public int A()
        {
            int result = 0;
            foreach (var e in studenti)
            {
                if (e.course == 5 || e.course == 6) result++;
            }
            return result;
        }

        public Dictionary<int, int> B()
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i <= 6; i++)
            {
                result.Add(i, 0);
            }

            foreach (var e in studenti)
            {
                if (e.age >= 18 && e.age <= 20) result[e.course]++;
            }
            return result;
        }

        public void C()
        {
            for (int i = 0; i < studenti.Count - 1; i++)
            {
                int minAge = studenti[i].age;
                int pos = i;
                for (int j = i; j < studenti.Count; j++)
                {
                    if (studenti[j].age < minAge)
                    {
                        minAge = studenti[j].age;
                        pos = j;
                    }

                    student t = studenti[i];
                    studenti[i] = studenti[pos];
                    studenti[pos] = t;
                }
            }

        }

        public void Sort(List<student> studenti, int startPosition, int endPosition)
        {
            for (int i = startPosition; i < endPosition - 1; i++)
            {
                int minCourse = studenti[i].course;
                int pos = i;
                for (int j = i + 1; j < endPosition; j++)
                {
                    if (studenti[j].course < minCourse)
                    {
                        minCourse = studenti[j].course;
                        pos = j;
                    }

                    student t = studenti[i];
                    studenti[i] = studenti[pos];
                    studenti[pos] = t;
                }
            }

        }

        public void D()
        {
            int start = 0;

            int i = 0;

            for (i = 0; i < studenti.Count; i++)
            {
                if (studenti[i].age != studenti[start].age)
                {
                    Console.WriteLine($"\n {start} {i}\n");
                    Sort(studenti, start, i);
                    start = i;
                }
            }

            Console.WriteLine($"\n {start} {i}\n");

        }
    }
}
