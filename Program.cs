using System;

public class Angajati
{
    private string nume;
    private int salariu;
    private string departament;

    public Angajati (string Nume, int Salariu, string Departament)
    {
        nume = Nume;
        salariu = Salariu;
        departament = Departament;
    }
    public void AfisareDetalii()
    {
        Console.WriteLine($"Nume: {nume}, Salariu: {salariu}, Departament: {departament}");
    }
}

public class Method
{
    static void Main()
    {
        Angajati primulAngajat = new Angajati("Victor Radu", 3000, "Marketing");
        Angajati alDoileaAngajat = new Angajati("Andrei Ionescu", 2500, "Sales");
        Angajati alTreileaAngajat = new Angajati("Maria Dumitrescu", 3200, "IT");

        primulAngajat.AfisareDetalii();
        alDoileaAngajat .AfisareDetalii();
        alTreileaAngajat.AfisareDetalii ();
    }
}