using System;
using System.Xml.Linq;

public class Mail
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private string _to;
    public string To
    {
        get { return _to; }
        set { _to = value; }
    }

    private string _from;
    public string From
    {
        get { return _from; }
        set { _from = value; }
    }

    private string _subject;
    public string Subject
    {
        get { return _subject; }
        set { _subject = value; }
    }

    private string _content;
    public string Content
    {
        get { return _content; }
        set { _content = value;}
    }

    private DateTime _receivedData;
    public DateTime ReceivedData
    { 
        get { return _receivedData; }
        set { _receivedData = value;} 
    }

    private double _size;
    public double Size
    { 
        get { return _size; }
        set { _size = value;} 
    }

    
    public Mail()
    {

    }

    public Mail(int _id, string _to, string _from, string _subject, string _content, DateTime _receivedData, double _size)
    {
        Id = _id;
        To = _to;
        From = _from;
        Subject = _subject;
        Content = _content;
        ReceivedData = _receivedData;
        Size = _size;
    }

    public override string ToString()
    {
        
        return string.Format("ID : {0}\n To :{1}\n From :{2}\n Subject :{3}\nContent :{4}\n " +
            "ReceivedDate :{5}\n Size : {6}\n", Id,To, From, Subject, Content, 
            ReceivedData.ToString("dd-MM-yyyy",null),Size.ToString("0.0"));
    }

    public override bool Equals(object obj)
    {
        Mail temp= obj as Mail;
        return temp.Id == this.Id;
        
    }
}
