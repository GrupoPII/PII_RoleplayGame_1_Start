using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class Mago : IPersonaje
{
    public string Nombre {get; set;}
    public int VidaInicial{get; set;}
    public int VidaActual {get; set;}
    public List<IElemento> Elementos {get; set;}
    public List <IElementoMagico> ElementosMagicos {get; set;}
    public int Fuerza {get; set;}
    public int PoderMagico {get; set;}
    public Mago(string nombre, int vidaInicial, int vidaActual, int fuerza, int poderMagico)
    {
        Nombre=nombre;
        VidaInicial=vidaInicial;
        VidaActual= vidaActual;
        Fuerza=fuerza;
        PoderMagico=poderMagico;
        Elementos= new List<IElemento>();
        ElementosMagicos = new List<IElementoMagico>();
    }
    public void AgregarElemento(IElemento elemento)
    {
        Elementos.Add(elemento);
    }
    public void QuitarElemento(IElemento elemento)
    {
        Elementos.Remove(elemento);
    }
    public void CambiarElemento(IElemento anterior, IElemento nuevo)
    {
        Elementos.Remove(anterior);
        Elementos.Remove(nuevo);
    }
    public int AtaqueTotal()
    {
        return this.Fuerza;
    }
    public int Defensa()
    {
        return this.PoderMagico;
    }
    public void Curar()
    {
        this.VidaActual=this.VidaInicial;
    }
    public void Atacar(IPersonaje personaje)
    {
        int total = personaje.VidaActual - this.Fuerza;
        total = total - personaje.DefensaTotal();
        personaje.VidaActual = total;
    }
    public void EstudiarMagia()
    {
        
    }

}