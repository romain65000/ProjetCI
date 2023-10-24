namespace NombresRomains.Test;

public class NombresRomainsTest
{
    [Fact]
    public void Test1()
    {
        // ETANT DONNE le chiffre 1
        const uint chiffre = 1;

        // QUAND on le convertit en nombres romains
        var nombreRomain = 
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "I"
        Assert.Equal("I", nombreRomain);
    }

    [Fact]
    public void Test2()
    {
        // ETANT DONNE le chiffre 2
        const uint chiffre = 2;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "II"
        Assert.Equal("II", nombreRomain);
    }
}