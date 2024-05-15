using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
public class Scripture
{
    Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {

        _reference = reference;
        _words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => new Word(word))
                     .ToList();


    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int words_Count = _words.Count;
        if (numberToHide >= words_Count)
        {
            foreach (var word in _words)
            {
                word.Hide();
            }
        }
        else
        {
            var indices = Enumerable.Range(0, words_Count).ToList();
            for (int i = 0; i < numberToHide; i++)
            {
                int index = rand.Next(indices.Count);
                _words[indices[index]].Hide();
                indices.RemoveAt(index)
            ;
            }
        }




    }
    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }
    public bool isCompletelyHidden()
    {
        return _words.All(word => word._IsHidden());
    }



}

public class Reference
{
    public string _book { get; set; }
    public int _chapter { get; set; }
    public int _verse { get; set; }
    public int? _end_verse { get; set; }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _end_verse = endVerse;
    }
    public string GetDisplayText()
    {
        if (_end_verse.HasValue)
        {
            return $"{_book} {_chapter}:{_verse}-{_end_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }

    }



}

public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        this._text = text;
        this._isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool _IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText(

    )
    {
        if (_isHidden)
        {
            return new string("___");
        }
        else
        {
            return _text;
        }

    }
};