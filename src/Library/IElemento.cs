<<<<<<< HEAD
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
=======
public interface IElemento
{
    string Name {get; set;}
    int Ataque {get; set;}
    int Defensa {get; set;}
    int ValorAtaque();
    int ValorDefensa();
>>>>>>> 345690138a3bf0d43c7f453c04dc58ce26ad4b64
}