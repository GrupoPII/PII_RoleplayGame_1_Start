public class Hechizo
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public Hechizo(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;
        Ataque = ataque;
        Defensa = defensa;
    }

    // Métodos que devuelve los valores del hechizo
    public int ValorAtaque()
    {
        return Ataque;
    }

    public int ValorDefensa()
    {
        return Defensa;
    }

    public override string ToString()
    {
        return $"{Nombre} (Atk: {Ataque}, Def: {Defensa})";
    }
}
