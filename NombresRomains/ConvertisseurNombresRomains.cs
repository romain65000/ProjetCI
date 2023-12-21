namespace NombresRomains;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffre)
    {
        switch (chiffre)
        {
            case 1:
                return "I";
            case 2:
                return "II";
            case 3:
                return "III";
            case 4:
                return "IV";
            case 5:
                return "V";
        }
    }
}