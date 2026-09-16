using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Enano //holasoy vale haciendo un cambio
{
    public string Nombre {get; set;}
    public int VidaInicial {get; set;}
    public int VidaActual{get; set;}
    public List<IElemento> Elementos {get; set;}
    public int Fuerza {get; set;}
    public int Resistencia {get; set;}
    public Enano(string nombre, int vidaInicial, int vidaActual, int fuerza, int resistencia)
    {
        Nombre=nombre;
        VidaInicial= vidaInicial;
        VidaActual=vidaActual;
        Fuerza=fuerza;
        Resistencia=resistencia;
        Elementos= new List<IElemento>();
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
        return this.Resistencia;
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
    public void Combatir ()
    {
    }
    }