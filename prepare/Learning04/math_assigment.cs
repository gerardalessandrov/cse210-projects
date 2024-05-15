public class MathAssigment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";
    public string GetHomeworkList()
    {
        return $"Section:{_textbookSection} Problems:{_problems}";
    }
    public  MathAssigment(string topic,string student_name,string text_book, string problems) :base(student_name,topic)
    {
        _textbookSection = text_book;
        _problems = problems;
    }
}