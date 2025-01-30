public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        // Initialize book, chapter, and verse
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        // Initialize book, chapter, verse, and endVerse
    }

    public string GetDisplayText() { return ""; }
}