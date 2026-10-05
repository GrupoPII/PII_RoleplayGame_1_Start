using System.Collections.Generic;

public class LibroDeHechizos : Elemento
{
    private List<Hechizo> Hechizos { get; set; } = new List<Hechizo>();

    public void AddHechizo(Hechizo hechizo)
    {
        Hechizos.Add(hechizo);
    }

    public void RemoveHechizo(Hechizo hechizo)
    {
        Hechizos.Remove(hechizo);
    }

    public int CantidadDeHechizos()
    {
        return Hechizos.Count;
    }
    public int ValorAtaque()
    {
        int total = 0;
        foreach (Hechizo h in Hechizos)
        {
            total += h.ValorAtaque(); // usa el método de Hechizo
        }
        return total;
    }
    public int ValorDefensa()
    {
        int total = 0;
        foreach (Hechizo h in Hechizos)
        {
            total += h.ValorDefensa(); // usa el método de Hechizo
        }
        return total;
    }
}
