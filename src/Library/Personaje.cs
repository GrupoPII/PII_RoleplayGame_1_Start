using System.Collections.Generic;

public abstract class Personaje
{
    public string Nombre { get; set; }
    public int VidaInicial { get; set; }
    public int VidaActual { get; set; }
    public int Fuerza { get; set; }
    public List<IElemento> Elementos { get; set; }

    public Personaje(string nombre, int vidaInicial, int fuerza)
    {
        Nombre = nombre;
        VidaInicial = vidaInicial;
        VidaActual = vidaInicial;
        Fuerza = fuerza;
        Elementos = new List<IElemento>();
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
        int index = Elementos.IndexOf(anterior);

        if (index != -1)
        {
            Elementos[index] = nuevo;
        }
    }

    public abstract int AtaqueTotal();

    public abstract int DefensaTotal();

    public virtual void Curar()
    {
        VidaActual = VidaInicial;
    }

    public virtual void Atacar(Personaje personaje)
    {
        int daño = AtaqueTotal() - personaje.DefensaTotal();

        if (daño < 0)
        {
            daño = 0;
        }

        personaje.VidaActual -= daño;

        if (personaje.VidaActual < 0)
        {
            personaje.VidaActual = 0;
        }
    }
}