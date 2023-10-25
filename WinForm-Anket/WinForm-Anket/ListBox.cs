namespace WinForm_Anket;

public class ListBox
{

    public Anket anket { get; set; }
    public ListBox(Anket anket)
    {
        this.anket = anket;
    }

    public override string ToString()
    {
        return $"{anket.Ad} {anket.Soyad} ->{anket.Email}";
    }


    
}



