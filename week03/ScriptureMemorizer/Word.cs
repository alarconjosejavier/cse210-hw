using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        // this was my original, then I used ChatGPT in mode BYU (special mode when I put all the AI rules on BYU in the memory of ChatPGT)
        // to guide me resolve the way that I can change the state of the variable.
        // if (_text == " ")
        // {
        //     _isHidden = true;
        // }

        // in this method we are changing the value of _isHidden to ture to be used in GetDisplayText method.
        // this means that the word is not visible
        _isHidden = true;
    }

    public void Show()
    {
        // this was my original, then I used ChatGPT in mode BYU (special mode when I put all the AI rules on BYU in the memory of ChatPGT)
        // to guide me resolve the way that I can change the state of the variable.
        // if (_text != " ")
        // {
        //     _isHidden = false;
        // }

        // in this method we are changing the value of _isHidden to false to be used in GetDisplayText method.
        // this means that the word is visible
        _isHidden = false;
    }

    public bool IsHidden()
    {
        // this method helps us to check is word is visible or not. Return true or false.
        return _isHidden;
    }

    public string GetDisplayText()
    {
        // this conditional write "_" for each letter in the word
        if (_isHidden == true)
        {
            // int quantity = _text.Length;
            string result = "";
            // I recevied help in this part because I was using int instead char.
            foreach (char l in _text)
            {
                // Received some help in this part becuase in my original I was rewriting the result instead add in everycycle.
                // string digit = "_";
                result = result + "_";
            }
            return result;
        }
        // if the condition is not true the method just return the string inside _text
        else
        {
            return _text;
        }
    }



}