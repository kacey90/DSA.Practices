using System.Collections.Generic;

namespace ToptalTests.Hackerrank
{
    public class GradingStudentsTask
    {
        public List<int> GradingStudents(List<int> grades)
        {
            var finalGrades = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    finalGrades.Add(grades[i]);
                    continue;
                }

                var nextMultipleOf5 = (grades[i] / 5 + 1) * 5;
                if (nextMultipleOf5 - grades[i] < 3)
                    finalGrades.Add(nextMultipleOf5);
                else
                    finalGrades.Add(grades[i]);
            }

            return finalGrades;
        }
    }
}
