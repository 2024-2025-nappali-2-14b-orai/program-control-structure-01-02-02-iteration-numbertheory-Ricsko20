namespace SzamelmeletProjekt;

public static class Szamelmelet
{
    // Az osztály csak egyszer kerül példányosításra
    public static bool OsztoE(int oszto, int szam)
    {
        /* elágazás
        if (szam % oszto == 0)
            return true;
        return
            false;
        */

        // return szam % oszto == 0 ? true : false;

        return szam % oszto == 0;
    }

    public static List<int> GetOsztok(int szam)
    {
        // 6 osztói:  (1), 2, 3, (6)
        // 10 osztói: (1),2,5, (10)
        
        List<int> osztok = new List<int>();
        if (szam == 0)
            return osztok;
        if (szam < 0)
            szam = -szam;

        osztok.Add(1);
        for (int i = 2; i <= szam/2; i++)
        {
            if (OsztoE(i,szam))
                osztok.Add(i);
        }
        osztok.Add(szam);
        return osztok;
    }

    public static string ListaToString(List<int> list)
    {
        return string.Join(", ", list);
    }

    public static bool PrimszamE(int szam)
    {
        // Primszám-e a szám
        return GetOsztok(szam).Count == 2;
    }

    public static List<int> GetPrimszamok(int kezdet, int veg)
    {
        List<int> primek = new List<int>();

        for (int i = kezdet; i <= veg; i++)
        {
            if(PrimszamE(i))
            {
                primek.Add(i);
            }
        }
        return primek;
    }

    public static List<int> GetPrimszamokHatarig(int veg)
    {
        List<int> hatrigPrimek = new List<int>();

        for (int i = 0; i <= veg; i++)
        {
            if(PrimszamE(i))
            {
                hatrigPrimek.Add(i);
            }
        }
        return hatrigPrimek;
    }
    public static int GetOsztokOsszege(int szam)
    {
        List<int> osztok = GetOsztok(szam);
        int osszeg = 0;

        for(int i = 0; i < osztok.Count;i++)
        {
            osszeg += osztok[i];
        }
        return osszeg;
    }

    public static bool TokeletesE(int szam)
    {
        if(GetOsztokOsszege(szam) == szam * 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static List<int> GetTokeletesek(int kezdet, int veg)
    {
        List<int> tokeletesek = new List<int>();

        for(int i = kezdet; i <= veg; i++)
        {
            if(TokeletesE(i))
            {
                tokeletesek.Add(i);
            }
        }
        return tokeletesek;
    }

    public static List<int> GetTokeletesekHatarig(int veg)
    {
        List<int> tokeletesekHatarig = new List<int>();

        for (int i = 0; i <= veg; i++)
        {
            if (TokeletesE(i))
            {
                tokeletesekHatarig.Add(i);
            }
        }
        return tokeletesekHatarig;
    }

    public static bool ParossavalSpecialisSzamE(int elsoSzam, int masodikSzam)
    {
        /*
          Párosával speciális szám a 12 és 42, mivel 12*42 = 504 = 21*24, azaz a két szám szorzata nem változik, ha számjegyeiket felcseréljük.
         */
        return false;
    }

    public static List<int> GetParossavalSepecialisSzamok(int kezdet, int veg)
    { 
        return new List<int>();
    }
}