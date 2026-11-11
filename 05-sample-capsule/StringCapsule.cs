using System.Net.Mime;

public class StringCapsule
{
    private string _content = "";

    public StringCapsule(string content)
    {
        //argumenter oppbevares i feltet
        _content = content;
    }

    public string Read()
    {
        // objektets innhold returneres
        
        return _content;
    }

    public void Replace(string content)
    {
        // feltet oppdateres..
        _content = content;
        return ;
    }
}
