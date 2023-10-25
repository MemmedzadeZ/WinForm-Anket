namespace WinForm_Anket;

public class Anket
{
   

      public string?  Ad { get; set; }
      public string? Soyad { get; set; }
      public string? Email { get; set; }
      public string? Telefon { get; set; }
      public string? DogumTarixi { get; set; }

    public Anket(string ad, string soyad, string email, string telefon, string dogumTarixi)
    {
        Ad = ad;
        Soyad = soyad;
        Email = email;
        Telefon = telefon;
        DogumTarixi = dogumTarixi;
    }



}



