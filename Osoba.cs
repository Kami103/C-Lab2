namespace ConsoleApp1;

public abstract class Osoba
{
    private string imie;
    private string nazwisko;
    private char[] pesel;

    public Osoba(string imie, string nazwisko, string pesel)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.pesel = pesel.ToCharArray();
    }

    public Osoba()
    {
    }

    public void SetFirstName(string imie)
    {
        Console.WriteLine("Ustawiono imie na: "+ imie);
        this.imie = imie;
    }

    public void SetLasttName(string nazwisko)
    {
        Console.WriteLine("Ustawiono nazwisko na: "+ nazwisko);
        this.nazwisko = nazwisko;
    }

    public void SetPesel(string pesel)
    {
        Console.WriteLine("Ustawiono PESEL na: "+ pesel);
        this.pesel = pesel.ToCharArray();
    }

    public int GetAge()
    {
        DateTime data1 = DateTime.Today;
        string yearS = ("20" + pesel[0].ToString() + pesel[1].ToString());
        int yearI = int.Parse(yearS);
        string monthS = pesel[2].ToString() + pesel[3].ToString();
        int monthI = int.Parse(monthS);
        if (monthI > 12)
        {
            monthI = monthI - int.Parse(pesel[2].ToString()) * 10;
        }

        string dayS = pesel[4].ToString() + pesel[5].ToString();
        int dayI = int.Parse(dayS);


        DateTime data2 = new DateTime(yearI, monthI, dayI);
        TimeSpan wiek = data1 - data2;
        return wiek.Days / 365;
    }

    public string GetGender()
    {
        if (int.Parse(pesel[9].ToString()) % 2 == 1)
        {
            return "M";
        }
        else
        {
            return "K";
        }
    }

    public virtual void GetEducationInfo()
    {
    }

    public string GetFullName()
    {
        return this.imie + " " + this.nazwisko;
    }

    public virtual bool CanGoAloneToHome()
    {
        return false;
    }
}