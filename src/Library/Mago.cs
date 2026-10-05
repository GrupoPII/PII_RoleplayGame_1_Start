using System.Collections.Generic;

public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public int VidaInicial { get; set; }
    public int VidaActual { get; set; }
    public List<IElemento> Elementos { get; set; }
    public List<IElementoMagico> ElementosMagicos { get; set; }
    public int Fuerza { get; set; }
    public int PoderMagico { get; set; }

    public Mago(string nombre, int vidaInicial, int fuerza, int poderMagico)
    {
        Nombre = nombre;
        VidaInicial = vidaInicial;
        VidaActual = vidaInicial; // al inicio la vida actual = inicial
        Fuerza = fuerza;
        PoderMagico = poderMagico;
        Elementos = new List<IElemento>();
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
        int index = Elementos.IndexOf(anterior);
        if (index != -1)
        {
            Elementos[index] = nuevo;
        }
    }

    public int AtaqueTotal()
    {
        int total = Fuerza;
        foreach (var elem in ElementosMagicos)
        {
            total += elem.ValorAtaque();
        }
        return total;
    }

    public int DefensaTotal()
    {
        int total = PoderMagico;
        foreach (var elem in ElementosMagicos)
        {
            total += elem.ValorDefensa();
        }
        return total;
    }

    public void Curar()
    {
        VidaActual = VidaInicial;
    }

    public void Atacar(IPersonaje personaje)
    {
        int daño = this.AtaqueTotal() - personaje.DefensaTotal();
        if (daño < 0) daño = 0;
        personaje.VidaActual -= daño;
        if (personaje.VidaActual < 0) personaje.VidaActual = 0;
    }

    public void EstudiarMagia()
    {
        PoderMagico += 10; // ejemplo: cada vez que estudia, aumenta su poder
    }
}
