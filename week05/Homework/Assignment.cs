<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3116b5edf44eaf85cd3dd2af547e25baf806e3f
public class Assignment
{
    private string _studentName = "";
    private string _assignmentName = "";



    public Assignment(string studentName, string assignmentName)
    {
        _studentName = studentName;
        _assignmentName = assignmentName;

    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public string Get_assignmentName()
    {
        return _assignmentName;
    }
    public void Set_studentName(string studentName)
    {
        _studentName = studentName;
    }
    public void set_assignmentName(string assignment)
    {
        _assignmentName = assignment;
    }

    public string GetSummary()
    {
        return "Student: {_studentName}, Assignment: {_assignmentName}";
    }

<<<<<<< HEAD
=======
=======
public class Assignment
{
    private string _studentName = "";
    private string _assignmentName = "";



    public Assignment(string studentName, string assignmentName)
    {
        _studentName = studentName;
        _assignmentName = assignmentName;

    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public string Get_assignmentName()
    {
        return _assignmentName;
    }
    public void Set_studentName(string studentName)
    {
        _studentName = studentName;
    }
    public void set_assignmentName(string assignment)
    {
        _assignmentName = assignment;
    }

    public string GetSummary()
    {
        return "Student: {_studentName}, Assignment: {_assignmentName}";
    }

>>>>>>> e0a3d674394e1dd1c8c05d09e00dfd83aa905b50
>>>>>>> e3116b5edf44eaf85cd3dd2af547e25baf806e3f
}