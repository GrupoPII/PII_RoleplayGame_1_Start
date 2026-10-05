public class Hechizo : ElementoAtaque : ElementoDefensa
{
    /*
    public string Nombre { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public Hechizo(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;
        Ataque = ataque;
        Defensa = defensa;
    }
*/
    public override string ToString()
    {
        return $"{Name} (Atk: {Atack}, Def: {Defense})";
    }
}
