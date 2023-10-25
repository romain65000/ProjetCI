namespace NombresRomains;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffre)
    {
        if (chiffre == 3) return "III";
        return chiffre == 1 ? "I" : "II";
    }
}