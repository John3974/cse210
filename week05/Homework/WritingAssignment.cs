<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> e3116b5edf44eaf85cd3dd2af547e25baf806e3f
public class WritingAssignment : Assignment

{
    private string _title;
    public WritingAssignment(string studentName, string assignmentName, string title) : base(studentName, assignmentName)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
<<<<<<< HEAD
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";

    }



=======
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
>>>>>>> e3116b5edf44eaf85cd3dd2af547e25baf806e3f
}