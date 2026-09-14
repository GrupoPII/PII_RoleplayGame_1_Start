using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class LibroDeHechizo
{
    public string Name {get; set;}
    private List <Hechizo> Hechizos = new List<Hechizo>();
    private int Ataque {get; set;}
    private int Defensa {get; set;}

    public void AddHechizo(Hechizo hechizo)
    {
        Hechizos.Add(hechizo)
    }
        public void RemoveHechizo(Hechizo hechizo)
    {
        Hechizos.Remove(hechizo)
    }
}