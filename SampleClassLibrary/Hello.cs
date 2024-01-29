namespace SampleClassLibrary;

public class Hello
{
    private readonly string _word;
    public Hello(string word)
    {
        _word = word;
    }

    public string Print()
    {
        return $"Hello {_word}";
    }
}
