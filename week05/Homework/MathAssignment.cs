
using System.Runtime.CompilerServices;

public class MathAssignment : Assignment
{
    private string _text_book_section;
    private string _Problems;


    public MathAssignment(string text_book_section, string Problems, string studentName, string assignmentName) : base(studentName, assignmentName)
    {
        _text_book_section = text_book_section;
        _Problems = Problems;
    }

    public void set_text_book_section(string text_book_section)
    {
        _text_book_section = text_book_section;
    }
    public void set_Problems(string Problems)
    {
        _Problems = Problems;
    }

    public string GetTextBookSection()
    {
        return _text_book_section;
    }
    public string GetProblems()
    {
        return _Problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()},Textbook section: {_text_book_section},problems:{_Problems}";
    }

}
