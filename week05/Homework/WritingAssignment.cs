<<<<<<< HEAD
public class WritingAssignment : Assignment

{
    private string _title;
    public WritingAssignment(string studentName, string assignmentName, string title) : base(studentName, assignmentName)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetstudentName();
        return $"{_title} by {studentName}";
    }
=======
public class WritingAssignment : Assignment

{
    private string _title;
    public WritingAssignment(string studentName, string assignmentName, string title) : base(studentName, assignmentName)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetstudentName();
        return $"{_title} by {studentName}";
    }
>>>>>>> e0a3d674394e1dd1c8c05d09e00dfd83aa905b50
}