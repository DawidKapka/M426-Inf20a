namespace Refactoring;

public class Grading
{
    public static char GetLetterGrade(int grade)
    {
        switch (isValidGrade(grade))
        {
            case true:
                return ((char)(grade + 64));
            default:
                throw new ArgumentException("unknown grade " + grade);
        }
    }

    private bool isValidGrade(int grade) 
    {
        return grade > 0 && grade <= 6;
    }
}