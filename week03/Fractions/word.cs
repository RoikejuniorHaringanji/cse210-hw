public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        // Initialize text and set _isHidden to false
    }

    public void Hide() { }
    public void Show() { }
    public bool IsHidden() { return false; }
    public string GetDisplayText() { return ""; }
}