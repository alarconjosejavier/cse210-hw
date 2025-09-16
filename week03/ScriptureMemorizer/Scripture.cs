class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        // copied from ChatGPT because I didn't know how to create a new list from a string, just copied the first line
        // the rest I receiving help from ChatGPT to guide me during the process. 
        _words = new List<Word>();
        String[] parts = text.Split(" ");
        
        foreach (string s in parts)
        {
            Word x = new Word(s);
            _words.Add(x);
        }
    }

    public void HideRandom(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return " ";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}