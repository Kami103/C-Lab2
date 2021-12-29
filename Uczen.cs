namespace ConsoleApp1;

public class Uczen : Osoba
{
    private string szkoła;
    private bool MozeSamWracacDoDomu;

    public Uczen(string imie, string nazwisko, string pesel, string szkoła, bool mozeSamWracacDoDomu) : base(imie, nazwisko, pesel)
    {
        this.szkoła = szkoła;
        MozeSamWracacDoDomu = mozeSamWracacDoDomu;
    }

    public Uczen()
    {
    }

    public override void GetEducationInfo()
    {
        base.GetEducationInfo();
        Console.WriteLine(szkoła);
    }

    public override bool CanGoAloneToHome()
    {
        base.CanGoAloneToHome();
        if (MozeSamWracacDoDomu == true|| this.GetAge()>12)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetSchool()
    {
        return this.szkoła;
    }

    public void SetSchool(string szkola)
    {
        this.szkoła = szkola;
    }

    public void SetCanGoHomeAlone(bool pozwolenie)
    {
        if (pozwolenie==true)
        {
            Console.WriteLine("Ma pozwolenie");
        }
        else
        {
            Console.WriteLine("Nie ma pozwolenia");
        }
        this.MozeSamWracacDoDomu = pozwolenie;
    }
}