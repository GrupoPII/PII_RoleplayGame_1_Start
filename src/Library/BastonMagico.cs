public class BastonMagico: IElementoMagico
{
    public string Nombre {get; set;}
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