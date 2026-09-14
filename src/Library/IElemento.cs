public class IElemento
{
    public string nombre;
    public int ataque;
    public int defensa;

    public IElemento(string nombre, int ataque, int defensa)
    {
      this.nombre=nombre;
      this.ataque=ataque;
      this.defensa=defensa;  
    }

    public int valorAtaque()
    {
        return ataque;
    }
    public int valorDefensa()
    {
        return defensa;
    }
}