using System.Reflection.Metadata.Ecma335;

public class Hacha : IElemento
{
    public string Name {get; set;}
    public int Ataque {get; set;}
    public int Defensa {get; set;}

    public int ValorAtaque()
    {
        return this.Ataque;
    }
        public int ValorDefensa()
    {
        return this.Defensa;
    }
}