/*
  HackerLand University has the following grading policy:

Every student receives a grade in the inclusive range from 0 to 100.
Any grade less than 40 is a failing grade.
Sam is a professor at the university and likes to round each student's  according to these rules:

If the difference between the grade and the next multiple of 5is less than 3,
round grade up to the next multiple of 5.
If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
Examples

grade =84 round to  (85 - 84 is less than 3)
grade =29 do not round (result is less than 40)
grade =57 do not round (60 - 57 is 3 or higher)
Given the initial value of grade for each of Sam's n students, write code to automate the rounding process.
*/
class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        var result = new List<int>();
        foreach (var grade in grades)
        {
            result.Add(RoundGrade(grade));
        }
        return result;
    }

    private static int RoundGrade(int grade)
    {
        if (grade < 38)
        {
            // No rounding needed for failing grades
            return grade;
        }

        int nextMultipleOf5 = ((grade / 5) + 1) * 5;

        if (nextMultipleOf5 - grade < 3)
        {
            // Round up to the next multiple of 5
            return nextMultipleOf5;
        }

        // No rounding needed
        return grade;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));
    }
}
