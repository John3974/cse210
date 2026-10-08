
public class WritingAssignment : Assignment

{
    private string _title;
    public WritingAssignment(string studentName, string assignmentName, string title) : base(studentName, assignmentName)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";

    }



}