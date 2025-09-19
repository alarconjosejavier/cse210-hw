using System.Numerics;
using System.Runtime.InteropServices;

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

    // creating a random variable outside the method
    Random r = new();

    // for this methos I received a lot help from ChatGPT most of the lines coming from ChatGPT
    // but asking during the procces to understand better.
    public void HideRandom(int numberToHide)

    {
        // creating a new list to put the index that are not hide
        List<int> visIndex = new List<int>();

        // using for to add to visIndex the index of the _word that are not visible
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                visIndex.Add(i);
            }
        }
        // a for to use the Fisher-Yates method (learning for ChatGPT) to get different custom indexes in visIndex list
        for (int i = visIndex.Count - 1; i > 0; i--)
        {
            int j = r.Next(i + 1);
            var tem = visIndex[i];
            visIndex[i] = visIndex[j];
            visIndex[j] = tem;
        }
        // var to choose the correct index of the list who contains the indexes that are not hide
        var l = Math.Min(numberToHide, visIndex.Count);

        // to change to hide the words inside the list _words
        for (int x = 0; x < l; x++)
        {
            // copied from ChatGPT received feedback because I was using the the wrong idenx _words[x].Hide(). 
            _words[visIndex[x]].Hide();
        }

    }

    // method to display the reference of the scripture and the verse
    public string GetDisplayText()
    {
        // for this method I received help from ChatGPT to understand the second part, completeVerse because I didn't
        // know how to obtain the information inside the list of the object
        // creating variables to store the elements inside the list _words
        string verse = "";
        List<string> completeVerse = new List<string>();
        // obtaining the information inside the list of objects _words.
        foreach (Word w in _words)
        {
            verse = w.GetDisplayText();
            completeVerse.Add(verse);
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", completeVerse)}";
    }

    // this method helps me to check is there is at least one word inside the List<word> visible, is there is any word not visible
    // so, the IsCompletelyHidden is true. I started the funcion and then I received guiandance from ChatGPT through Seudocode and then
    // it helped to understand why my first logic was bad.
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}